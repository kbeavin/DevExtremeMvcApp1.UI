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
    
    public partial class mileageserver_log
    {
        public int msl_identity { get; set; }
        public int msl_session { get; set; }
        public System.DateTime msl_datetime { get; set; }
        public string msl_user { get; set; }
        public string msl_text { get; set; }
        public string msl_source { get; set; }
        public Nullable<int> msl_type { get; set; }
        public string msl_origin { get; set; }
        public string msl_destination { get; set; }
        public string msl_origin_text { get; set; }
        public string msl_destination_text { get; set; }
    }
}
