using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcSyst
    {
        public string Company { get; set; }
        public string BillingTypeCd { get; set; }
        public decimal StartTransId { get; set; }
        public string AcfipartNum { get; set; }
        public string AcfipartRevNum { get; set; }
        public string ExtSystemCd { get; set; }
        public string EasyApilog { get; set; }
        public string Dlllog { get; set; }
        public string LogicPackPath { get; set; }
        public string JavaPath { get; set; }
        public string HicolPath { get; set; }
        public string Psipath { get; set; }
        public string Psipassphrase { get; set; }
        public string LocationId { get; set; }
        public string Server { get; set; }
        public string Recipient { get; set; }
        public string MessagePath { get; set; }
        public string JobPrefix { get; set; }
        public string PcjobPrefix { get; set; }
        public string RlsClassSls { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public string DepartureRsnCode { get; set; }
        public int Pmuid { get; set; }
        public string CustNamePrefix { get; set; }
        public string RefundBcd { get; set; }
        public string RefundGrpPrefix { get; set; }
        public int RefundGrpLength { get; set; }
        public int RefundGrpNextNum { get; set; }
        public string RefundBankAcctId { get; set; }
        public int RefundPmuid { get; set; }
        public string RefundTaxRegionCode { get; set; }
        public string RefundTaxCode { get; set; }
        public string RefundRateCode { get; set; }
        public string ArsweepLogPath { get; set; }
        public string ReconFileExportPath { get; set; }
        public string ReconFileImportPath { get; set; }
        public string ReconPayImportPath { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public bool ViewAllDepartClient { get; set; }
    }
}
