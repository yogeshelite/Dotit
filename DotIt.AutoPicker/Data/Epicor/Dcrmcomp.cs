using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Dcrmcomp
    {
        public string DeviceId { get; set; }
        public string Company { get; set; }
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
