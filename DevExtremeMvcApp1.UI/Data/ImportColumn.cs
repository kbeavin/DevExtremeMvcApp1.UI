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
    
    public partial class ImportColumn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ImportColumn()
        {
            this.ImportColumnContents = new HashSet<ImportColumnContent>();
            this.ImportRowContentLinkErrors = new HashSet<ImportRowContentLinkError>();
        }
    
        public int ImportColumnId { get; set; }
        public int ImportDefinitionId { get; set; }
        public string Name { get; set; }
        public int ImportDataTypeId { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> Sequence { get; set; }
        public Nullable<int> ExtraInfoColumnId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportColumnContent> ImportColumnContents { get; set; }
        public virtual ImportDataType ImportDataType { get; set; }
        public virtual ImportDefinition ImportDefinition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportRowContentLinkError> ImportRowContentLinkErrors { get; set; }
    }
}
