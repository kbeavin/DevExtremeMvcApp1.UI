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
    
    public partial class tank
    {
        public int tank_nbr { get; set; }
        public string cmp_id { get; set; }
        public string tank_loc { get; set; }
        public string tank_model_id { get; set; }
        public string tank_cmd_code { get; set; }
        public Nullable<short> tank_highdip { get; set; }
        public Nullable<short> tank_lowdip { get; set; }
        public Nullable<short> tank_warndip { get; set; }
        public string tank_dip_unit { get; set; }
        public Nullable<int> tank_capacity { get; set; }
        public string tank_cap_unit { get; set; }
        public string tank_type1 { get; set; }
        public string tank_inuse { get; set; }
    
        public virtual tankmodel tankmodel { get; set; }
    }
}
