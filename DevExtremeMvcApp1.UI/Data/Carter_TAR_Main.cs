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
    
    public partial class Carter_TAR_Main
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Carter_TAR_Main()
        {
            this.Carter_tar_charges = new HashSet<Carter_tar_charges>();
            this.Carter_TAR_MainSub = new HashSet<Carter_TAR_MainSub>();
            this.Carter_TAR_Stops = new HashSet<Carter_TAR_Stops>();
        }
    
        public int Main_ID { get; set; }
        public string Main_Dispatcher { get; set; }
        public int Main_Status { get; set; }
        public System.DateTime Main_PickupDT { get; set; }
        public System.DateTime Main_DeliveryDT { get; set; }
        public string Main_Trip { get; set; }
        public string Main_PRO { get; set; }
        public Nullable<int> Main_WGT { get; set; }
        public string Main_Route { get; set; }
        public int Main_TruckType { get; set; }
        public string Main_Company_Shipper_ID { get; set; }
        public string Main_Company_ConsigneeID { get; set; }
        public Nullable<int> Main_Num_PUs { get; set; }
        public int Main_Reason { get; set; }
        public string Main_BillTo { get; set; }
        public string Main_Notes { get; set; }
        public string Main_RequestBy { get; set; }
        public string Main_RequestByPh { get; set; }
        public System.DateTime Main_RequestDate { get; set; }
        public byte Main_Mode { get; set; }
        public byte Main_Commodity { get; set; }
        public string Main_Driver { get; set; }
        public Nullable<int> Main_PCS { get; set; }
        public decimal Main_CostMile { get; set; }
        public double Main_Miles { get; set; }
        public int Main_NotesPertainTo { get; set; }
        public string Main_ResponsibleParty { get; set; }
        public string main_carriernotes { get; set; }
        public Nullable<int> main_startloc { get; set; }
        public Nullable<int> main_endloc { get; set; }
        public Nullable<System.DateTime> main_datecreated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Carter_tar_charges> Carter_tar_charges { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Carter_TAR_MainSub> Carter_TAR_MainSub { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Carter_TAR_Stops> Carter_TAR_Stops { get; set; }
    }
}
