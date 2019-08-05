﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class JobOwi
    {
        public string Company { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int OprSeq { get; set; }
        public int ScheduleId { get; set; }
        public string ResourceGrpId { get; set; }
        public int Machines { get; set; }
        public decimal HoursPerMachine { get; set; }
        public DateTime? StartDate { get; set; }
        public decimal StartHour { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal DueHour { get; set; }
        public decimal ActProdHours { get; set; }
        public decimal ActSetupHours { get; set; }
        public DateTime? QueStartDate { get; set; }
        public decimal QueStartHour { get; set; }
        public DateTime? MoveDueDate { get; set; }
        public decimal MoveDueHour { get; set; }
        public DateTime? TearDwnEndDate { get; set; }
        public decimal TearDwnEndHour { get; set; }
        public DateTime? WitearDwnEndDate { get; set; }
        public decimal WitearDwnEndHour { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}