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
    
    public partial class MCMESSAGE
    {
        public int MCM_ID { get; set; }
        public short MCM_SEQUENCE { get; set; }
        public string MCM_REQUESTTYPE { get; set; }
        public string MCM_STATUS { get; set; }
        public string MCM_ORIGINATORIDTYPE { get; set; }
        public string MCM_ORIGINATORID { get; set; }
        public string MCM_ORISERVICE { get; set; }
        public string MCM_ORIADDRESS { get; set; }
        public string MCM_RECIPIENTIDTYPE { get; set; }
        public string MCM_RECIPIENTID { get; set; }
        public string MCM_RECIPSERVICE { get; set; }
        public string MCM_RECIPADDRESS { get; set; }
        public System.DateTime MCM_CREATEDATE { get; set; }
        public System.DateTime MCM_CREATETIME { get; set; }
        public Nullable<System.DateTime> MCM_SENTDATE { get; set; }
        public Nullable<System.DateTime> MCM_SENTTIME { get; set; }
        public string MCM_PRIORITY { get; set; }
        public string MCM_RETURNRECEIPT { get; set; }
        public string MCM_SUBJECT { get; set; }
        public string MCM_MESSAGETEXT { get; set; }
        public Nullable<short> MCM_MACRONUM { get; set; }
        public string MCM_MACROVER { get; set; }
        public string MCM_SERVICEMSGID { get; set; }
        public string MCM_HANDLING { get; set; }
        public string MCM_STATUSMESSAGE { get; set; }
        public string MCM_REPLYTOMSGID { get; set; }
        public string MCM_DIRECTION { get; set; }
        public Nullable<System.DateTime> MCM_SITINGDATE { get; set; }
        public Nullable<System.DateTime> MCM_SITINGTIME { get; set; }
        public Nullable<int> MCM_LATITUDE { get; set; }
        public Nullable<int> MCM_LONGITUDE { get; set; }
        public string MCM_EXTSENSORALARM { get; set; }
        public string MCM_VEHICLEIGNITION { get; set; }
        public string MCM_PROXIMITY { get; set; }
        public Nullable<double> MCM_MILESFROM { get; set; }
        public string MCM_DIRECTIONFROM { get; set; }
        public string MCM_CITY { get; set; }
        public string MCM_STATE { get; set; }
        public string MCM_VALIDITY { get; set; }
        public string MCM_MTAVAILABLE { get; set; }
        public string MCM_TRACTOR { get; set; }
        public string MCM_EXCEPTIONS { get; set; }
        public Nullable<int> MOV_NUMBER { get; set; }
        public string MCM_SYSTEMPROCESSED { get; set; }
        public Nullable<int> LGH_NUMBER { get; set; }
        public string MCM_DRIVER1 { get; set; }
        public string MCM_UPDATEDBY { get; set; }
        public Nullable<System.DateTime> MCM_UPDATEDATE { get; set; }
        public Nullable<System.DateTime> MCM_UPDATETIME { get; set; }
    }
}