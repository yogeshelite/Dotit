using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imdmractn
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int Dmrnum { get; set; }
        public int ActionNum { get; set; }
        public DateTime? ActionDate { get; set; }
        public string ActionType { get; set; }
        public decimal Quantity { get; set; }
        public string DestinationType { get; set; }
        public string WarehouseCode { get; set; }
        public string BinNum { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int DmrseqNum { get; set; }
        public decimal UnitCredit { get; set; }
        public decimal DocUnitCredit { get; set; }
        public string CreditUm { get; set; }
        public string DebitMemoNum { get; set; }
        public int DebitMemoLine { get; set; }
        public string VendRmanum { get; set; }
        public string ActionUserId { get; set; }
        public DateTime? SysDate { get; set; }
        public int SysTime { get; set; }
        public string CommentText { get; set; }
        public string ReasonCode { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool LockRate { get; set; }
        public string FldWarehouseCode { get; set; }
        public string FldBinNum { get; set; }
        public string LegalNumber { get; set; }
        public decimal Rpt1UnitCredit { get; set; }
        public decimal Rpt2UnitCredit { get; set; }
        public decimal Rpt3UnitCredit { get; set; }
        public string RateGrpCode { get; set; }
        public string Resolution { get; set; }
        public bool ReturnToSupplier { get; set; }
        public string PackSlip { get; set; }
        public int PackLine { get; set; }
        public bool DisableRejection { get; set; }
        public string DisableRejectionChar { get; set; }
        public string RefInvoiceNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool IssuedComplete { get; set; }
    }
}
