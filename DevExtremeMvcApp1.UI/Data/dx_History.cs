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
    
    public partial class dx_History
    {
        public long dx_ident { get; set; }
        public string dx_importid { get; set; }
        public string dx_sourcename { get; set; }
        public System.DateTime dx_sourcedate { get; set; }
        public System.DateTime dx_actiondate { get; set; }
        public long dx_hist_seq { get; set; }
        public string dx_origin { get; set; }
        public string dx_command { get; set; }
        public string dx_commandstring { get; set; }
        public Nullable<int> dx_returncode { get; set; }
        public Nullable<int> dx_orderhdrnumber { get; set; }
        public string dx_ordernumber { get; set; }
        public string dx_docnumber { get; set; }
        public Nullable<int> dx_spid { get; set; }
    }
}
