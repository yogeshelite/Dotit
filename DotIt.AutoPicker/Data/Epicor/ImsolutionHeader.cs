using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImsolutionHeader
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string SolutionId { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string AppVersion { get; set; }
        public string InternalNotes { get; set; }
        public string Notes { get; set; }
        public DateTime? LastExported { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string SolutionTypeId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int BuildIteration { get; set; }
        public string SolutionReference { get; set; }
    }
}
