﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ichosoft.Extensions.Configuration.UnitTest.Resources {
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
    internal class InformationString {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal InformationString() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Ichosoft.Extensions.Configuration.UnitTest.Resources.InformationString", typeof(InformationString).Assembly);
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
        ///   Looks up a localized string similar to [{EntryType}] {Description}.
        /// </summary>
        internal static string Entry_General {
            get {
                return ResourceManager.GetString("Entry.General", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{EntryType}] {Test} [{Result}].
        /// </summary>
        internal static string Result_General {
            get {
                return ResourceManager.GetString("Result.General", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{EntryType}] {Test}
        ///        Expected: {Expected}
        ///        Observed: {Observed}.
        /// </summary>
        internal static string ResultInfo_Comparison_SingleVariable {
            get {
                return ResourceManager.GetString("ResultInfo.Comparison.SingleVariable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{EntryType}] {Test}
        ///        Plaint-text: {PlainString}
        ///        Cipher-text: {CipherString}
        ///        IV: {IV}.
        /// </summary>
        internal static string ResultInfo_Encrypt {
            get {
                return ResourceManager.GetString("ResultInfo.Encrypt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{EntryType}] {Test}
        ///        Plaint-text: {PlainString}
        ///        Cipher-text: {CipherString}
        ///        IV: {IV}
        ///        Decyphered-text: {DecipherString}
        ///        Byte-length: {ByteLength}.
        /// </summary>
        internal static string ResultInfo_EncryptDecrypt {
            get {
                return ResourceManager.GetString("ResultInfo.EncryptDecrypt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{EntryType}] {Test}
        ///        Key: {Key}
        ///        Expected: {Expected}
        ///        Observed: {Observed}.
        /// </summary>
        internal static string ResultInfo_KeyPair {
            get {
                return ResourceManager.GetString("ResultInfo.KeyPair", resourceCulture);
            }
        }
    }
}
