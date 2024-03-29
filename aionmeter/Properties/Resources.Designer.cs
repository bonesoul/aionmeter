﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AIONMeter.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AIONMeter.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Damage Done.
        /// </summary>
        internal static string DamageDone {
            get {
                return ResourceManager.GetString("DamageDone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;time&gt;\d{4}.\d{2}.\d{2} \d{2}:\d{2}:\d{2}) : (?&lt;critical&gt;(Critical Hit!)*)(?&lt;who&gt;.*?)(| has) inflicted (?&lt;amount&gt;\d+(.\d{3})*) (|critical )damage on (?&lt;target&gt;.*)..
        /// </summary>
        internal static string FILTER_DIRECT_DAMAGE {
            get {
                return ResourceManager.GetString("FILTER_DIRECT_DAMAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;time&gt;\d{4}.\d{2}.\d{2} \d{2}:\d{2}:\d{2}) : (?&lt;critical&gt;(Critical Hit!)*)(?&lt;who&gt;.*?)(| has) inflicted (?&lt;amount&gt;\d+(.\d{3})*) (|critical )damage on (?&lt;target&gt;.*?) by using (?&lt;skill&gt;.*)..
        /// </summary>
        internal static string FILTER_DIRECT_DAMAGE_SKILL {
            get {
                return ResourceManager.GetString("FILTER_DIRECT_DAMAGE_SKILL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;time&gt;\d{4}.\d{2}.\d{2} \d{2}:\d{2}:\d{2}) : (?&lt;who&gt;.*?) recovered (?&lt;amount&gt;\d+(.\d{3})*) HP by using (?&lt;skill&gt;.*)..
        /// </summary>
        internal static string FILTER_DIRECT_HEALING {
            get {
                return ResourceManager.GetString("FILTER_DIRECT_HEALING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;time&gt;\d{4}.\d{2}.\d{2} \d{2}:\d{2}:\d{2}) : (?&lt;target&gt;.*?) recovered (?&lt;amount&gt;\d+(.\d{3})*) HP because (?&lt;who&gt;.*?) used (?&lt;skill&gt;.*)..
        /// </summary>
        internal static string FILTER_DIRECT_HEALING_SKILL {
            get {
                return ResourceManager.GetString("FILTER_DIRECT_HEALING_SKILL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;time&gt;\d{4}.\d{2}.\d{2} \d{2}:\d{2}:\d{2}) : (?&lt;target&gt;.*?) received (?&lt;amount&gt;\d+(.\d{3})*) damage due to the effect of (?&lt;skill&gt;.*)..
        /// </summary>
        internal static string FILTER_DOT {
            get {
                return ResourceManager.GetString("FILTER_DOT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;time&gt;\d{4}.\d{2}.\d{2} \d{2}:\d{2}:\d{2}) : (You left the group|The group has been disbanded)..
        /// </summary>
        internal static string FILTER_GROUP_DISBAND {
            get {
                return ResourceManager.GetString("FILTER_GROUP_DISBAND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;time&gt;\d{4}.\d{2}.\d{2} \d{2}:\d{2}:\d{2}) : \[charname:(?&lt;who&gt;\w+);0.0196 .*?\]: (?&lt;message&gt;.*).
        /// </summary>
        internal static string FILTER_GROUP_MESSAGE {
            get {
                return ResourceManager.GetString("FILTER_GROUP_MESSAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;time&gt;\d{4}.\d{2}.\d{2} \d{2}:\d{2}:\d{2}) : (?&lt;target&gt;.*?) is in the continuous HP recovery state because (?&lt;who&gt;.*?) used (?&lt;skill&gt;.*)..
        /// </summary>
        internal static string FILTER_HOT_1 {
            get {
                return ResourceManager.GetString("FILTER_HOT_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;time&gt;\d{4}.\d{2}.\d{2} \d{2}:\d{2}:\d{2}) : .*? restored (?&lt;amount&gt;\d+(.\d{3})*) of (?&lt;target&gt;.*?)&apos;s HP by using (?&lt;skill&gt;.*)..
        /// </summary>
        internal static string FILTER_HOT_2 {
            get {
                return ResourceManager.GetString("FILTER_HOT_2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;time&gt;\d{4}.\d{2}.\d{2} \d{2}:\d{2}:\d{2}) : (?&lt;who&gt;\w+) has joined your group..
        /// </summary>
        internal static string FILTER_PLAYER_JOIN_GROUP {
            get {
                return ResourceManager.GetString("FILTER_PLAYER_JOIN_GROUP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;time&gt;\d{4}.\d{2}.\d{2} \d{2}:\d{2}:\d{2}) : (?&lt;who&gt;\w+) (has|have) been kicked out of (your|the) group..
        /// </summary>
        internal static string FILTER_PLAYER_KICKED {
            get {
                return ResourceManager.GetString("FILTER_PLAYER_KICKED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;time&gt;\d{4}.\d{2}.\d{2} \d{2}:\d{2}:\d{2}) : (?&lt;who&gt;\w+) has left your group..
        /// </summary>
        internal static string FILTER_PLAYER_LEFT_GROUP {
            get {
                return ResourceManager.GetString("FILTER_PLAYER_LEFT_GROUP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;time&gt;\d{4}.\d{2}.\d{2} \d{2}:\d{2}:\d{2}) : You changed the connection status to Online..
        /// </summary>
        internal static string FILTER_PLAYER_ONLINE {
            get {
                return ResourceManager.GetString("FILTER_PLAYER_ONLINE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;time&gt;\d{4}.\d{2}.\d{2} \d{2}:\d{2}:\d{2}) : (?&lt;who&gt;.*?) (?&lt;message&gt;.*).
        /// </summary>
        internal static string FILTER_SELF_MESSAGE {
            get {
                return ResourceManager.GetString("FILTER_SELF_MESSAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;time&gt;\d{4}.\d{2}.\d{2} \d{2}:\d{2}:\d{2}) : (?&lt;who&gt;.*?) summoned (?&lt;target&gt;.*?) by using (?&lt;skill&gt;.*?) to let it attack (.*)..
        /// </summary>
        internal static string FILTER_SUMMON_1 {
            get {
                return ResourceManager.GetString("FILTER_SUMMON_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;time&gt;\d{4}.\d{2}.\d{2} \d{2}:\d{2}:\d{2}) : (?&lt;who&gt;.*?) summoned (?&lt;target&gt;.*?) by using (?&lt;skill&gt;.*)..
        /// </summary>
        internal static string FILTER_SUMMON_2 {
            get {
                return ResourceManager.GetString("FILTER_SUMMON_2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Healing Done.
        /// </summary>
        internal static string HealingDone {
            get {
                return ResourceManager.GetString("HealingDone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You.
        /// </summary>
        internal static string You {
            get {
                return ResourceManager.GetString("You", resourceCulture);
            }
        }
    }
}
