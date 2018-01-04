using System.Diagnostics;
using System.Windows.Forms;

namespace MSIBootstrapperDecompiler.Helpers
{
    public static class ProcessHelper
    {
        /// <summary>
        /// Runs cmd command with specified params 
        /// </summary>
        /// <param name="cmdCommand"></param>
        public static void RunCmdProcess(string cmdCommand)
        {
            var procStartInfo = new ProcessStartInfo("CMD.exe")
            {
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = cmdCommand
            };
            var proc = new Process {StartInfo = procStartInfo};
            proc.Start();
            var error = proc.StandardError.ReadToEnd();
            //var result = proc.StandardOutput.ReadToEnd();
            proc.WaitForExit();

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
            }
        }
    }
}
