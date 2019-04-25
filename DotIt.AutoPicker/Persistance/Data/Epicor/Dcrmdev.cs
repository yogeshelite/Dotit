using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Dcrmdev
    {
        public string DeviceId { get; set; }
        public int DeviceUserLimit { get; set; }
        public string DeviceAddress { get; set; }
        public DateTime? LastInitializeDate { get; set; }
        public int LastInitializeTime { get; set; }
        public DateTime? LastFullSyncDate { get; set; }
        public int LastFullSyncTime { get; set; }
        public DateTime? LastSyncDate { get; set; }
        public int LastSyncTime { get; set; }
        public string DatabaseName { get; set; }
        public string LogicalName { get; set; }
        public string HostName { get; set; }
        public string NetworkType { get; set; }
        public bool MultipleUsers { get; set; }
        public string ServiceName { get; set; }
        public string OtherParams { get; set; }
        public int QuoteNumBlockSize { get; set; }
        public int QuoteNumBlockReorderPoint { get; set; }
        public int QuoteNumBlockWarnPoint { get; set; }
        public int CustNumBlockSize { get; set; }
        public int CustNumBlockReorderPoint { get; set; }
        public int CustNumBlockWarnPoint { get; set; }
        public int ConNumBlockSize { get; set; }
        public int CallSeqNumBlockSize { get; set; }
        public bool SalesEngineerDevice { get; set; }
        public bool SendFinancial { get; set; }
        public bool SendOrder { get; set; }
        public bool SendProduction { get; set; }
        public string UseLanorWan { get; set; }
        public string Dcrmcharacter01 { get; set; }
        public string Dcrmcharacter02 { get; set; }
        public string Dcrmcharacter03 { get; set; }
        public string Dcrmcharacter04 { get; set; }
        public decimal Dcrmnumber01 { get; set; }
        public decimal Dcrmnumber02 { get; set; }
        public decimal Dcrmnumber03 { get; set; }
        public decimal Dcrmnumber04 { get; set; }
        public DateTime? Dcrmdate01 { get; set; }
        public DateTime? Dcrmdate02 { get; set; }
        public DateTime? Dcrmdate03 { get; set; }
        public DateTime? Dcrmdate04 { get; set; }
        public bool Dcrmlogical01 { get; set; }
        public bool Dcrmlogical02 { get; set; }
        public bool Dcrmlogical03 { get; set; }
        public bool Dcrmlogical04 { get; set; }
        public int HdcaseNumBlockSize { get; set; }
        public int HdcaseNumBlockReorderPoint { get; set; }
        public int HdcaseNumBlockWarnPoint { get; set; }
        public bool SendHelpDesk { get; set; }
        public string ServiceBusServerFqdn { get; set; }
        public int ServiceBusHttpport { get; set; }
        public int ServiceBusTcpport { get; set; }
        public string ServiceBusNamespace { get; set; }
        public string ServiceBusSecretIssuerName { get; set; }
        public string ServiceBusSecretIssuerSecret { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
