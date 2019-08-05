using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imactrevision
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public int ActrevisionUid { get; set; }
        public int ActtypeUid { get; set; }
        public string RevisionCode { get; set; }
        public string RevisionStatus { get; set; }
        public string Description { get; set; }
        public bool SendToReviewJournal { get; set; }
        public string Company { get; set; }
        public bool IsDefault { get; set; }
        public string Rtype { get; set; }
        public string Abtver { get; set; }
        public int VersionUid { get; set; }
        public string PrevAbtver { get; set; }
        public string PatchAbtver { get; set; }
        public string PrevPatchAbtver { get; set; }
        public int LocVer { get; set; }
        public int PatchLocVer { get; set; }
        public bool UpdatePatchVer { get; set; }
        public bool Modified { get; set; }
        public bool PrevModified { get; set; }
        public bool ManuallyUpdVer { get; set; }
        public bool NeedPrePostUpdate { get; set; }
        public string PrevRevisionStatus { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool PendingConversion { get; set; }
        public bool CanUseSysAssembly { get; set; }
        public string PostAssemblyName { get; set; }
    }
}
