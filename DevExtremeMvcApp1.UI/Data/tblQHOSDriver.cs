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
    
    public partial class tblQHOSDriver
    {
        public int SN { get; set; }
        public string DriverID { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string DriverGroup { get; set; }
        public int WeekCycle { get; set; }
        public Nullable<int> DepotID { get; set; }
        public Nullable<int> Retired { get; set; }
        public System.DateTime updated_on { get; set; }
    }
}
