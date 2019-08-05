using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ExtSystem
    {
        public string ExtSystemId { get; set; }
        public string ExtSystemName { get; set; }
        public string TransferMethod { get; set; }
        public bool FinancialInt { get; set; }
        public string ServiceBusServerFqdn { get; set; }
        public int ServiceBusHttpport { get; set; }
        public int ServiceBusTcpport { get; set; }
        public string ServiceBusNamespace { get; set; }
        public string ServiceBusSecretIssuerName { get; set; }
        public string ServiceBusSecretIssuerSecret { get; set; }
        public string EnvironmentId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Sbdomain { get; set; }
        public string Sbuser { get; set; }
        public string Sbpassword { get; set; }
        public string SbtokenProvider { get; set; }
        public string SbconnectionString { get; set; }
        public string Settings { get; set; }
    }
}
