using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Immemo
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string RelatedToSchemaName { get; set; }
        public string RelatedToFile { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Key3 { get; set; }
        public DateTime? MemoDate { get; set; }
        public int MemoNum { get; set; }
        public string MemoUserId { get; set; }
        public bool Notify { get; set; }
        public string NotifyUserId { get; set; }
        public DateTime? NotifyDate { get; set; }
        public string MemoDesc { get; set; }
        public string MemoText { get; set; }
        public string CategoryId { get; set; }
        public Guid RelatedToSysRowId { get; set; }
        public bool ChangeTrackChargeIdbtn { get; set; }
        public decimal ChangeTrackAmount { get; set; }
        public string ChangeTrackChargeId { get; set; }
        public string ChangeTrackChargeDesc { get; set; }
        public string ChangeTrackStatus { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
