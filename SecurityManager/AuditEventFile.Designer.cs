﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SecurityManager {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AuditEventFile {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AuditEventFile() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SecurityManager.AuditEventFile", typeof(AuditEventFile).Assembly);
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
        ///   Looks up a localized string similar to Neuspesno pokrenut timer korisnika:{0}.
        /// </summary>
        internal static string PokreniTimerNeuspesno {
            get {
                return ResourceManager.GetString("PokreniTimerNeuspesno", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uspesno pokrenut timer korisnika:{0}.
        /// </summary>
        internal static string PokreniTimerUspesno {
            get {
                return ResourceManager.GetString("PokreniTimerUspesno", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Neuspesno ponisti timer korisnika:{0}.
        /// </summary>
        internal static string PonistiTimerNeuspesno {
            get {
                return ResourceManager.GetString("PonistiTimerNeuspesno", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uspesno ponisten timer korisnika:{0}.
        /// </summary>
        internal static string PonistiTimerUspesno {
            get {
                return ResourceManager.GetString("PonistiTimerUspesno", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Neuspesno postavljen timer korisnika:{0}.
        /// </summary>
        internal static string PostaviTimerNeuspesno {
            get {
                return ResourceManager.GetString("PostaviTimerNeuspesno", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uspesno postavljen timer korisnika:{0}.
        /// </summary>
        internal static string PostaviTimerUspesno {
            get {
                return ResourceManager.GetString("PostaviTimerUspesno", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Neuspesno zaustavljen timer korisnika:{0}.
        /// </summary>
        internal static string ZaustaviTimerNeuspesno {
            get {
                return ResourceManager.GetString("ZaustaviTimerNeuspesno", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uspesno zaustavljen timer korisnika:{0}.
        /// </summary>
        internal static string ZaustaviTimerUspesno {
            get {
                return ResourceManager.GetString("ZaustaviTimerUspesno", resourceCulture);
            }
        }
    }
}
