using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imform1099
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string FormTypeId { get; set; }
        public int Form1099Num { get; set; }
        public string Comment { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int CountryNum { get; set; }
        public string Country { get; set; }
        public bool SecondTinnotice { get; set; }
        public bool Corrected { get; set; }
        public bool TwoStepCorrection { get; set; }
        public bool UserModified { get; set; }
        public bool Void { get; set; }
        public bool Printed { get; set; }
        public bool Submitted { get; set; }
        public bool SubmittedElectronic { get; set; }
        public DateTime? ElectronicDate { get; set; }
        public int PaymentYear { get; set; }
        public string Tintype { get; set; }
        public int CorrectionOf { get; set; }
        public int VendorNum { get; set; }
        public int CorrectedBy { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string NameControl { get; set; }
        public string AccountNum { get; set; }
        public string Tin { get; set; }
        public int TimeSubmitted { get; set; }
        public DateTime GenDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool NonUs { get; set; }
        public bool Fatca { get; set; }
        public string Us1099ktranType { get; set; }
        public string Us1099kmerchCatCode { get; set; }
    }
}
