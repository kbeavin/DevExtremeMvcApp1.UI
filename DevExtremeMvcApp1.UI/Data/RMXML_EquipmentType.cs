//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevExtremeMvcApp1_UI.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class RMXML_EquipmentType
    {
        public int id { get; set; }
        public Nullable<int> TmwXmlImportLog_id { get; set; }
        public Nullable<int> RootElementID { get; set; }
        public Nullable<int> ParentLevel { get; set; }
        public Nullable<int> CurrentLevel { get; set; }
        public string EquipmentTypeDescrip { get; set; }
        public string EquipmentTypeCode { get; set; }
        public Nullable<int> EquipmentTypeCount { get; set; }
        public Nullable<System.DateTime> EquipmentTypeAddedDate { get; set; }
        public string Tmw_SynchStatus { get; set; }
        public Nullable<System.DateTime> lastupdatedate { get; set; }
        public string lastupdateuser { get; set; }
    }
}
