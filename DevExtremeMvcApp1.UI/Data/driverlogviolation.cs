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
    
    public partial class driverlogviolation
    {
        public string mpp_id { get; set; }
        public short drl_month { get; set; }
        public short drl_year { get; set; }
        public Nullable<short> drl_mph { get; set; }
        public Nullable<short> drl_hr10 { get; set; }
        public Nullable<short> drl_hr15 { get; set; }
        public Nullable<short> drl_hr70 { get; set; }
        public string drl_comments { get; set; }
        public byte[] timestamp { get; set; }
        public int drl_id { get; set; }
        public Nullable<System.DateTime> drl_date { get; set; }
        public string ViolationCode { get; set; }
        public Nullable<int> drl_level { get; set; }
        public string drl_ignore { get; set; }
        public string drl_updateby { get; set; }
        public Nullable<System.DateTime> drl_updatedate { get; set; }
        public string drl_settledcode { get; set; }
        public string drl_settledby { get; set; }
        public Nullable<System.DateTime> drl_settleddate { get; set; }
        public string drl_ignorecode { get; set; }
        public string drl_ignoreby { get; set; }
        public Nullable<System.DateTime> drl_ignoredate { get; set; }
        public string drl_comment2 { get; set; }
    
        public virtual DriverLogViolationType DriverLogViolationType { get; set; }
    }
}
