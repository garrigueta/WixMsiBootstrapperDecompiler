﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSIBootstrapperDecompiler.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MSIBootstrapperDecompiler.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to delete the temporary files generated before closing?.
        /// </summary>
        internal static string Close_deletion_message {
            get {
                return ResourceManager.GetString("Close_deletion_message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It was not possible to open the file selected, probably is it using by other process or doesn&apos;t have proper assigned permissions and be sure is a Wix Bootstrapper generated bundle. More info: .
        /// </summary>
        internal static string Error_selecting_file {
            get {
                return ResourceManager.GetString("Error_selecting_file", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Executable Files (EXE)|*.EXE.
        /// </summary>
        internal static string File_extensions {
            get {
                return ResourceManager.GetString("File_extensions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The program will close.
        /// </summary>
        internal static string Program_close_message {
            get {
                return ResourceManager.GetString("Program_close_message", resourceCulture);
            }
        }
    }
}