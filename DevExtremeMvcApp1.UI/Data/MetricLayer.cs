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
    
    public partial class MetricLayer
    {
        public int LayerSN { get; set; }
        public string LayerCode { get; set; }
        public Nullable<int> LayerLevel { get; set; }
        public string MetricCode { get; set; }
        public string LayerName { get; set; }
        public string MetricParmName { get; set; }
        public string SqlForSplit { get; set; }
        public string ValueList { get; set; }
        public Nullable<int> ParentLayerSN { get; set; }
        public string NewMetricCodeFormat { get; set; }
        public string UseOtherOrigParmsYN { get; set; }
    }
}
