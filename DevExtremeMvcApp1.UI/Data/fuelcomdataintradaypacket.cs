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
    
    public partial class fuelcomdataintradaypacket
    {
        public int fuelcomdataintradaypacket_id { get; set; }
        public string packet { get; set; }
        public string acknowledgement { get; set; }
        public string transaction_number { get; set; }
        public string status { get; set; }
        public string error_message { get; set; }
        public Nullable<System.DateTime> created_datetime { get; set; }
        public Nullable<System.DateTime> processed_datetime { get; set; }
    }
}