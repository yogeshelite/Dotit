using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imcoasegment
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Coacode { get; set; }
        public int SegmentNbr { get; set; }
        public string SegmentName { get; set; }
        public string Abbreviation { get; set; }
        public int MaxLength { get; set; }
        public int MinLength { get; set; }
        public bool Dynamic { get; set; }
        public bool UseRefEntity { get; set; }
        public string RefEntity { get; set; }
        public bool AllowAlpha { get; set; }
        public string EntryControl { get; set; }
        public bool SegSelfBal { get; set; }
        public int Level { get; set; }
        public bool SummaryBal { get; set; }
        public bool DetailBal { get; set; }
        public bool KeepOpenBal { get; set; }
        public int DisplayOrder { get; set; }
        public bool AutoCreateSegVals { get; set; }
        public string SelfBalAcct { get; set; }
        public string BalSegValue1 { get; set; }
        public string BalSegValue2 { get; set; }
        public string BalSegValue3 { get; set; }
        public string BalSegValue4 { get; set; }
        public string BalSegValue5 { get; set; }
        public string BalSegValue6 { get; set; }
        public string BalSegValue7 { get; set; }
        public string BalSegValue8 { get; set; }
        public string BalSegValue9 { get; set; }
        public string BalSegValue10 { get; set; }
        public string BalSegValue11 { get; set; }
        public string BalSegValue12 { get; set; }
        public string BalSegValue13 { get; set; }
        public string BalSegValue14 { get; set; }
        public string BalSegValue15 { get; set; }
        public string BalSegValue16 { get; set; }
        public string BalSegValue17 { get; set; }
        public string BalSegvalue18 { get; set; }
        public string BalSegValue19 { get; set; }
        public string BalSegValue20 { get; set; }
        public string SelfOffAcct { get; set; }
        public string OffSegValue1 { get; set; }
        public string OffSegValue2 { get; set; }
        public string OffSegValue3 { get; set; }
        public string OffSegValue4 { get; set; }
        public string OffSegValue5 { get; set; }
        public string OffSegValue6 { get; set; }
        public string OffSegValue7 { get; set; }
        public string OffSegValue8 { get; set; }
        public string OffSegValue9 { get; set; }
        public string OffSegValue10 { get; set; }
        public string OffSegValue11 { get; set; }
        public string OffSegValue12 { get; set; }
        public string OffSegValue13 { get; set; }
        public string OffSegValue14 { get; set; }
        public string OffSegValue15 { get; set; }
        public string OffSegValue16 { get; set; }
        public string OffSegValue17 { get; set; }
        public string OffSegValue18 { get; set; }
        public string OffSegValue19 { get; set; }
        public string OffSegValue20 { get; set; }
        public string ReverseCategoryId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool CnisCficode { get; set; }
        public string SegValueField { get; set; }
        public string DescFieldName { get; set; }
        public bool GlobalCoasegment { get; set; }
        public bool GlobalCoasegmentValues { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalValuesLock { get; set; }
    }
}
