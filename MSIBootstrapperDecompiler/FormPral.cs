using Microsoft.Deployment.WindowsInstaller;
using Microsoft.Deployment.WindowsInstaller.Linq;
using MSIBootstrapperDecompiler.Helpers;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing;
using MSIBootstrapperDecompiler.Properties;

namespace MSIBootstrapperDecompiler
{
    public partial class FormPral : Form
    {
        private string _darkPath = string.Empty;
        private string _filePath = string.Empty;
        private string _fileName = string.Empty;
        private string _currentPath = string.Empty;
        private string _destPath = string.Empty;
        private string _destFile = string.Empty;

        public FormPral()
        {
            InitializeComponent();
        }

        #region EVENTS

        private void linkLabelWixToolsetInstallLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://wixtoolset.org");
        }

        private void FormPral_Load(object sender, EventArgs e)
        {

            _darkPath = ConfigHelper.ReadConfigString("WixDarkPath");
            _currentPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\temp\";

            if (RegistryHelper.CheckStringArrayInstalled(GetNeddedWixVersions()))
            {
                labelInstalled.Visible = true;
                linkLabelWixToolsetInstallLink.Visible = false;
            }
            else
            {
                labelInstalled.Visible = false;
                linkLabelWixToolsetInstallLink.Visible = true;
            }
        }

        private static string[] GetNeddedWixVersions()
        {
            return new[] { "WiX Toolset v3.11", "WiX Toolset v3.10", "WiX Toolset v4" };
        }

        private void FormPral_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.IsNullOrEmpty(_currentPath) || !Directory.Exists(_currentPath)) return;
            var dialogResult = MessageBox.Show(Resources.Close_deletion_message, Resources.Program_close_message, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                FileHelper.DeleteFolderContent(_currentPath);                    
            }
        }

        private void linkLabelOutputFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_destPath);
        }

        private void buttonFindFile_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridViewResults.Enabled = false;
            buttonFindFile.Enabled = false;
            panelRequirements.Enabled = false;

            try
            {
                openFileDialogMSI.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                openFileDialogMSI.Filter = Resources.File_extensions;
                if (openFileDialogMSI.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    _filePath = openFileDialogMSI.FileName;
                    _fileName = Path.GetFileName(_filePath);

                    textBoxFileName.Text = _fileName;

                    _destPath = _currentPath + Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 8);

                    linkLabelOutputFolder.Visible = true;

                    _destFile = _destPath + "\\" + _fileName;

                    Directory.CreateDirectory(_currentPath);

                    Directory.CreateDirectory(_destPath);

                    File.Copy(_filePath, _destFile);

                    var cmdCommand = (@"/C """"" + _darkPath + "\" -x \"" + _destPath + "\" \"" + _destFile + "\"\"");

                    ProcessHelper.RunCmdProcess(cmdCommand);

                    var fileEntries = Directory.GetFiles(_destPath + "\\AttachedContainer\\");

                    var msiPath = fileEntries[0];

                    try
                    {
                        using (var database = new QDatabase(msiPath, DatabaseOpenMode.ReadOnly))
                        {
                            var properties = from p in database.Properties
                                             select p;

                            foreach (var item in properties.AsEnumerable().OrderBy(x => x.Property))
                            {
                                dataGridViewResults.Rows.Add(item.Property, item.Value);
                            }
                        }
                    }
                    catch (InstallerException iex)
                    {
                        MessageBox.Show(Resources.Error_selecting_file + iex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            

            dataGridViewResults.Enabled = true;
            buttonFindFile.Enabled = true;
            panelRequirements.Enabled = true;
            Cursor.Current = Cursors.Arrow;
        }

        #endregion

        private void dataGridViewResults_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            var currentMouseOverRow = dataGridViewResults.HitTest(e.X, e.Y).RowIndex;
            var currentMouseOverColumn = dataGridViewResults.HitTest(e.X, e.Y).ColumnIndex;

            var actualCell =
                dataGridViewResults.Rows[currentMouseOverRow].Cells[currentMouseOverColumn];
            dataGridViewResults.CurrentCell = actualCell;

            var contextMenu = new ContextMenu();

            var menuItem = new MenuItem("Copy");
            menuItem.Click += (senderClick, eClick) => CustomMenuItemClickEvent(currentMouseOverRow, currentMouseOverColumn);

            contextMenu.MenuItems.Add(menuItem);
            contextMenu.Show(dataGridViewResults, new Point(e.X, e.Y));
        }

        private void CustomMenuItemClickEvent(object currentMouseOverRowClick, object currentMouseOverColumnClick)
        {
            var actualCell =
                dataGridViewResults.Rows[(int) currentMouseOverRowClick].Cells[(int) currentMouseOverColumnClick];
            var formattedValue = actualCell.FormattedValue;
            if (formattedValue == null) return;
            var currentValue = formattedValue.ToString();
            Clipboard.SetText(currentValue);
        }
    }

   
}
