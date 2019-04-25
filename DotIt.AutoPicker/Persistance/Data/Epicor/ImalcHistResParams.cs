using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImalcHistResParams
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
        public int RunNbr { get; set; }
        public int AllocTgtNbr { get; set; }
        public int AllocTgtSeq { get; set; }
        public int ParamNbr { get; set; }
        public int RunType { get; set; }
        public string BookId { get; set; }
        public decimal ActualValue { get; set; }
        public string ResBalAcct { get; set; }
        public string ResBalSegVal1 { get; set; }
        public string ResBalSegVal2 { get; set; }
        public string ResBalSegVal3 { get; set; }
        public string ResBalSegVal4 { get; set; }
        public string ResBalSegVal5 { get; set; }
        public string ResBalSegVal6 { get; set; }
        public string ResBalSegVal7 { get; set; }
        public string ResBalSegVal8 { get; set; }
        public string ResBalSegVal9 { get; set; }
        public string ResBalSegVal10 { get; set; }
        public string ResBalSegVal11 { get; set; }
        public string ResBalSegVal12 { get; set; }
        public string ResBalSegVal13 { get; set; }
        public string ResBalSegVal14 { get; set; }
        public string ResBalSegVal15 { get; set; }
        public string ResBalSegVal16 { get; set; }
        public string ResBalSegVal17 { get; set; }
        public string ResBalSegVal18 { get; set; }
        public string ResBalSegVal19 { get; set; }
        public string ResBalSegVal20 { get; set; }
        public string Coacode { get; set; }
        public int CycleUid { get; set; }
        public int CycleNumber { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool Ytdbalance { get; set; }
    }
}
