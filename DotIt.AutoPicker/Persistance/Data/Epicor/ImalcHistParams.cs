using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImalcHistParams
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string BatchId { get; set; }
        public string AllocId { get; set; }
        public int ParamNbr { get; set; }
        public int RunNbr { get; set; }
        public string BookId { get; set; }
        public int RunType { get; set; }
        public string ParamName { get; set; }
        public int ParamType { get; set; }
        public string ParamDesc { get; set; }
        public string Coacode { get; set; }
        public string AcctBalAcct { get; set; }
        public string AcctBalSegVal1 { get; set; }
        public string AcctBalSegVal2 { get; set; }
        public string AcctBalSegVal3 { get; set; }
        public string AcctBalSegVal4 { get; set; }
        public string AcctBalSegVal5 { get; set; }
        public string AcctBalSegVal6 { get; set; }
        public string AcctBalSegVal7 { get; set; }
        public string AcctBalSegVal8 { get; set; }
        public string AcctBalSegVal9 { get; set; }
        public string AcctBalSegVal10 { get; set; }
        public string AcctBalSegVal11 { get; set; }
        public string AcctBalSegVal12 { get; set; }
        public string AcctBalSegVal13 { get; set; }
        public string AcctBalSegVal14 { get; set; }
        public string AcctBalSegVal15 { get; set; }
        public string AcctBalSegVal16 { get; set; }
        public string AcctBalSegVal17 { get; set; }
        public string AcctBalSegVal18 { get; set; }
        public string AcctBalSegVal19 { get; set; }
        public string AcctBalSegVal20 { get; set; }
        public bool UseTgtAcct { get; set; }
        public string BaqexportId { get; set; }
        public string StatUomcode { get; set; }
        public int AcctParamValSrc { get; set; }
        public int SumParamValSrc { get; set; }
        public bool Reversed { get; set; }
        public DateTime? ReversedDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int NfsrcMapUid { get; set; }
        public int NftgtSeqNbr { get; set; }
        public bool Ytdbalance { get; set; }
    }
}
