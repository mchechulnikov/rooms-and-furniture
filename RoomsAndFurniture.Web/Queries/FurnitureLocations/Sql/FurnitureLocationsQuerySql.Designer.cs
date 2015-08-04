﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoomsAndFurniture.Web.Queries.FurnitureLocations.Sql {
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
    internal class FurnitureLocationsQuerySql {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal FurnitureLocationsQuerySql() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RoomsAndFurniture.Web.Queries.FurnitureLocations.Sql.FurnitureLocationsQuerySql", typeof(FurnitureLocationsQuerySql).Assembly);
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
        ///   Looks up a localized string similar to select fl.*
        ///    from FurnitureLocation as fl
        ///    inner join Furniture as f on f.Id = fl.FurnitureId
        ///    where 
        ///        f.Type = @Type and
        ///        f.CreateDate &lt;= @Date and (
        ///            f.RemoveDate is null or
        ///            f.RemoveDate &gt; @Date
        ///        ) and
        ///        fl.BeginDate &lt;= @Date and (
        ///            fl.EndDate is null or
        ///            fl.EndDate &gt; @Date
        ///        )  and
        ///        fl.RoomId = @RoomId.
        /// </summary>
        internal static string GetFurnitureLocationByRoomIdAndDateQuery {
            get {
                return ResourceManager.GetString("GetFurnitureLocationByRoomIdAndDateQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select fl.*
        ///    from FurnitureLocation as fl
        ///    inner join Furniture as f on f.Id = fl.FurnitureId
        ///    where 
        ///        f.Type = @Type and
        ///        f.CreateDate &lt;= @Date and (
        ///            f.RemoveDate is null or
        ///            f.RemoveDate &gt; @Date
        ///        ) and
        ///        fl.BeginDate &lt;= @Date and (
        ///            fl.EndDate is null or
        ///            fl.EndDate &gt; @Date
        ///        )  and
        ///        fl.RoomId = @RoomId.
        /// </summary>
        internal static string GetFurnitureLocationByTypeRoomIdAndDateQuery {
            get {
                return ResourceManager.GetString("GetFurnitureLocationByTypeRoomIdAndDateQuery", resourceCulture);
            }
        }
    }
}