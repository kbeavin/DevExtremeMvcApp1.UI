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
    
    public partial class MobileCommMessageNodePropertyDefinition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MobileCommMessageNodePropertyDefinition()
        {
            this.MobileCommMessageNodeProperties = new HashSet<MobileCommMessageNodeProperty>();
        }
    
        public int PropertyDefinitionId { get; set; }
        public int NodeDefinitionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DatatypeId { get; set; }
        public string FriendlyName { get; set; }
        public string Expression { get; set; }
    
        public virtual MobileCommDataType MobileCommDataType { get; set; }
        public virtual MobileCommMessageNodeDefinition MobileCommMessageNodeDefinition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MobileCommMessageNodeProperty> MobileCommMessageNodeProperties { get; set; }
    }
}
