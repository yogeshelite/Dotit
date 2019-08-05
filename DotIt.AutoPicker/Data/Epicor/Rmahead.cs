using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Rmahead
    {
        public bool OpenRma { get; set; }
        public string Company { get; set; }
        public int Rmanum { get; set; }
        public DateTime? Rmadate { get; set; }
        public int CustNum { get; set; }
        public string DebitMemoRef { get; set; }
        public string ClcallNum { get; set; }
        public string XrefRmanumber { get; set; }
        public int HdcaseNum { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public string ShipToNum { get; set; }
        public int ConNum { get; set; }
        public bool AutoPrintReady { get; set; }
        public int BtcustNum { get; set; }
        public bool UseOts { get; set; }
        public string Otsname { get; set; }
        public string Otsaddress1 { get; set; }
        public string Otsaddress2 { get; set; }
        public string Otsaddress3 { get; set; }
        public string Otscity { get; set; }
        public string Otsstate { get; set; }
        public string Otszip { get; set; }
        public string OtsresaleId { get; set; }
        public string OtstaxRegionCode { get; set; }
        public string Otscontact { get; set; }
        public string OtsfaxNum { get; set; }
        public string OtsphoneNum { get; set; }
        public int OtscountryNum { get; set; }
        public int ShipToCustNum { get; set; }
        public int InvoiceNum { get; set; }
        public string TranDocTypeId { get; set; }
        public string LegalNumber { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string RetInvoiceNum { get; set; }
        public string Eccrmanum { get; set; }
        public string EcccustRef { get; set; }
        public bool DocumentPrinted { get; set; }
        public string Rmacomment { get; set; }
        public string WebComment { get; set; }
        public bool EpicorFsa { get; set; }

        public virtual RmaheadUd RmaheadUd { get; set; }
    }
}
