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
    
    public partial class city
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public city()
        {
            this.tempstops = new HashSet<tempstop>();
        }
    
        public int cty_code { get; set; }
        public string cty_name { get; set; }
        public string cty_state { get; set; }
        public string cty_zip { get; set; }
        public string cty_areacode { get; set; }
        public Nullable<int> cty_splc { get; set; }
        public string cty_county { get; set; }
        public Nullable<decimal> cty_latitude { get; set; }
        public Nullable<decimal> cty_longitude { get; set; }
        public string cty_region1 { get; set; }
        public string cty_region2 { get; set; }
        public string cty_region3 { get; set; }
        public string cty_region4 { get; set; }
        public string cty_nmstct { get; set; }
        public byte[] timestamp { get; set; }
        public Nullable<int> cty_comm_zone { get; set; }
        public string cty_country { get; set; }
        public string cty_updatedby { get; set; }
        public Nullable<System.DateTime> cty_updateddate { get; set; }
        public Nullable<System.DateTime> cty_createdate { get; set; }
        public string rand_city { get; set; }
        public string rand_state { get; set; }
        public string rand_county { get; set; }
        public string alk_city { get; set; }
        public string alk_state { get; set; }
        public string alk_county { get; set; }
        public Nullable<short> cty_fuelcreate { get; set; }
        public string county_name { get; set; }
        public string rand_county_name { get; set; }
        public string alk_county_name { get; set; }
        public string rand_verified { get; set; }
        public Nullable<System.DateTime> rand_verified_date { get; set; }
        public string alk_verified { get; set; }
        public Nullable<System.DateTime> alk_verified_date { get; set; }
        public Nullable<double> cty_GMTDelta { get; set; }
        public string cty_DSTApplies { get; set; }
        public string alk_region { get; set; }
        public Nullable<short> cty_TZMins { get; set; }
        public Nullable<int> cty_countyfips { get; set; }
        public Nullable<int> cty_statefips { get; set; }
        public Nullable<int> cty_msa { get; set; }
        public string cty_CityShort { get; set; }
        public Nullable<System.DateTime> cty_GeoCodeRequested { get; set; }
        public Nullable<int> cty_ALK_FileValidatedYR { get; set; }
        public string cty_splc_char { get; set; }
        public System.Data.Entity.Spatial.DbGeography citypoint { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tempstop> tempstops { get; set; }
    }
}
