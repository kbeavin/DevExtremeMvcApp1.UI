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
    
    public partial class MetricAlertHistory
    {
        public Nullable<int> AlertBatch { get; set; }
        public Nullable<int> AlertBatchIdx { get; set; }
        public string MetricCode { get; set; }
        public Nullable<System.DateTime> Upd_Daily { get; set; }
        public Nullable<System.DateTime> PlainDate { get; set; }
        public Nullable<decimal> DailyCount { get; set; }
        public Nullable<decimal> DailyTotal { get; set; }
        public Nullable<decimal> DailyValue { get; set; }
        public Nullable<decimal> ThresholdAlertValue { get; set; }
        public string ThresholdOperator { get; set; }
        public string ThresholdAlertEmailAddress { get; set; }
        public Nullable<System.DateTime> dtEmailed { get; set; }
        public string StatusCode { get; set; }
        public string UserComment { get; set; }
        public string ProcedureName { get; set; }
        public string SQLScriptRun { get; set; }
        public Nullable<int> spid { get; set; }
        public int sn { get; set; }
        public Nullable<System.DateTime> dtInsert { get; set; }
        public string BatchGUID { get; set; }
    }
}