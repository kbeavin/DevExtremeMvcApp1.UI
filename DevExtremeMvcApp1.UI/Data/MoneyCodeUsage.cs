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
    
    public partial class MoneyCodeUsage
    {
        public int mcu_id { get; set; }
        public Nullable<int> mcu_CodeId { get; set; }
        public Nullable<System.DateTime> mcu_CreateDate { get; set; }
        public Nullable<System.DateTime> mcu_ActivationDate { get; set; }
        public string mcu_CarrierId { get; set; }
        public string mcu_ContractId { get; set; }
        public Nullable<decimal> mcu_OriginalAmount { get; set; }
        public Nullable<decimal> mcu_AmountUsed { get; set; }
        public string mcu_PayeeName { get; set; }
        public string mcu_FirstInitial { get; set; }
        public string mcu_Coxref { get; set; }
        public string mcu_IssuedTo { get; set; }
        public string mcu_WhoOrIssuedBy { get; set; }
        public string mcu_Notes { get; set; }
        public string mcu_CodeStatus { get; set; }
        public Nullable<System.DateTime> mcu_VoidedDate { get; set; }
        public Nullable<decimal> mcu_FeeAmount { get; set; }
        public Nullable<decimal> mcu_EFSCheckFee { get; set; }
        public string mcu_ExpressCode { get; set; }
        public string mcu_DeductFee { get; set; }
        public string mcu_CreditFlagVoided { get; set; }
        public Nullable<decimal> mcu_ConversionRate { get; set; }
        public string mcu_OneTimeUse { get; set; }
        public Nullable<System.DateTime> mcu_ReportedCarrier { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string LastUpdatedBy { get; set; }
        public System.DateTime LastUpdatedOn { get; set; }
        public string PayDetailAction { get; set; }
        public Nullable<int> pyd_number { get; set; }
        public string ErrorMessage { get; set; }
    }
}
