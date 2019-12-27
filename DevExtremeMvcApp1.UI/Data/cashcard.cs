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
    
    public partial class cashcard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cashcard()
        {
            this.cdexpresscashes = new HashSet<cdexpresscash>();
            this.cdfuelbills = new HashSet<cdfuelbill>();
            this.efs_card_advance_request = new HashSet<efs_card_advance_request>();
            this.fuelpurchaseds = new HashSet<fuelpurchased>();
        }
    
        public string crd_cardnumber { get; set; }
        public string crd_accountid { get; set; }
        public string crd_customerid { get; set; }
        public string crd_status { get; set; }
        public string crd_usecard { get; set; }
        public int crd_directdeposit { get; set; }
        public string crd_atmaccess { get; set; }
        public string crd_vruaccess { get; set; }
        public string crd_limitnetworkbycard { get; set; }
        public string asgn_type { get; set; }
        public string asgn_id { get; set; }
        public string crd_firstname { get; set; }
        public string crd_lastname { get; set; }
        public string crd_driverlicensenum { get; set; }
        public string crd_driverlicensestate { get; set; }
        public string crd_unitnumber { get; set; }
        public string crd_driver { get; set; }
        public string crd_trailernumber { get; set; }
        public string crd_tripnumber { get; set; }
        public string crd_fuelpurchaseyn { get; set; }
        public Nullable<decimal> crd_purchaselimit { get; set; }
        public Nullable<decimal> crd_onetimepurchaselimit { get; set; }
        public Nullable<int> crd_diesellimit { get; set; }
        public Nullable<int> crd_reeferlimit { get; set; }
        public string crd_purchrenewdaily { get; set; }
        public string crd_purchrenewmon { get; set; }
        public string crd_purchrenewtue { get; set; }
        public string crd_purchrenewwed { get; set; }
        public string crd_purchrenewthu { get; set; }
        public string crd_purchrenewfri { get; set; }
        public string crd_purchrenewsat { get; set; }
        public string crd_purchrenewsun { get; set; }
        public string crd_purchrenewtrip { get; set; }
        public string crd_expcashflagyn { get; set; }
        public Nullable<decimal> crd_cashlimit { get; set; }
        public Nullable<decimal> crd_onetimecashlimit { get; set; }
        public Nullable<decimal> crd_cashbalance { get; set; }
        public string crd_cashrenewdaily { get; set; }
        public string crd_cashrenewmon { get; set; }
        public string crd_cashrenewtue { get; set; }
        public string crd_cashrenewwed { get; set; }
        public string crd_cashrenewthu { get; set; }
        public string crd_cashrenewfri { get; set; }
        public string crd_cashrenewsat { get; set; }
        public string crd_cashrenewsun { get; set; }
        public string crd_cashrenewtrip { get; set; }
        public string crd_phoneserviceyn { get; set; }
        public Nullable<decimal> crd_phoneamountlimit { get; set; }
        public string crd_phonerenewdaily { get; set; }
        public string crd_phonerenewsun { get; set; }
        public string crd_phonerenewmon { get; set; }
        public string crd_phonerenewtue { get; set; }
        public string crd_phonerenewwed { get; set; }
        public string crd_phonerenewthu { get; set; }
        public string crd_phonerenewfri { get; set; }
        public string crd_phonerenewsat { get; set; }
        public string crd_phonerenewtrip { get; set; }
        public Nullable<decimal> crd_oilamountlimit { get; set; }
        public Nullable<int> crd_oillimit { get; set; }
        public string crd_oilrenewdaily { get; set; }
        public string crd_oilrenewsun { get; set; }
        public string crd_oilrenewmon { get; set; }
        public string crd_oilrenewtue { get; set; }
        public string crd_oilrenewwed { get; set; }
        public string crd_oilrenewthu { get; set; }
        public string crd_oilrenewfri { get; set; }
        public string crd_oilrenewsat { get; set; }
        public string crd_oilrenewtrip { get; set; }
        public string crd_updatestatus { get; set; }
        public string crd_errormessage { get; set; }
        public string crd_purchrenewdaily_old { get; set; }
        public string crd_purchrenewtrip_old { get; set; }
        public string crd_cashrenewdaily_old { get; set; }
        public string crd_cashrenewtrip_old { get; set; }
        public string crd_phonerenewdaily_old { get; set; }
        public string crd_phonerenewtrip_old { get; set; }
        public string crd_oilrenewdaily_old { get; set; }
        public string crd_oilrenewtrip_old { get; set; }
        public Nullable<System.DateTime> limitnetwork_expdate { get; set; }
        public Nullable<System.DateTime> crd_createddate { get; set; }
        public string crd_carrier { get; set; }
        public string crd_thirdpartytype { get; set; }
        public string crd_pinnumber { get; set; }
        public string crd_vendor { get; set; }
        public string crd_importbatch { get; set; }
        public string crd_crdnumbershort { get; set; }
        public string crd_onetimefuel_off { get; set; }
        public string crd_mpp_status { get; set; }
        public string crd_drivername { get; set; }
        public string crd_save_offline { get; set; }
        public string crd_updatedby { get; set; }
        public Nullable<System.DateTime> crd_updateddate { get; set; }
        public string crd_updatedapp { get; set; }
        public string crd_primary_tractor { get; set; }
        public string crd_is_parent_card { get; set; }
        public string crd_parent_cardnumber { get; set; }
        public string crd_Type { get; set; }
        public string crd_AdvanceFlag { get; set; }
        public string crd_send_tpr_as_employeenum { get; set; }
        public string crd_send_car_as_employeenum { get; set; }
        public string crd_retired { get; set; }
        public string crd_carrier_card { get; set; }
        public string crd_is_rfid { get; set; }
        public string crd_rfid_location { get; set; }
        public string crd_rfid_tag_id { get; set; }
    
        public virtual cdacctcode cdacctcode { get; set; }
        public virtual cdcustcode cdcustcode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdexpresscash> cdexpresscashes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdfuelbill> cdfuelbills { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<efs_card_advance_request> efs_card_advance_request { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fuelpurchased> fuelpurchaseds { get; set; }
    }
}
