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
    
    public partial class ImportColumnContent
    {
        public int ImportColumnContentId { get; set; }
        public int ImportRowContentId { get; set; }
        public int ImportColumnId { get; set; }
        public string Data { get; set; }
    
        public virtual ImportColumn ImportColumn { get; set; }
        public virtual ImportRowContent ImportRowContent { get; set; }
    }
}
