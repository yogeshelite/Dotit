﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EsStdtype
    {
        public EsStdtype()
        {
            EsCutting = new HashSet<EsCutting>();
            EsFinishing = new HashSet<EsFinishing>();
            EsFolding = new HashSet<EsFolding>();
            EsGroups = new HashSet<EsGroups>();
            EsInk = new HashSet<EsInk>();
            EsPlate = new HashSet<EsPlate>();
            EsPrepress = new HashSet<EsPrepress>();
            EsPress = new HashSet<EsPress>();
            EsStock = new HashSet<EsStock>();
        }

        public string Company { get; set; }
        public string RecId { get; set; }
        public string StdTypeUserId { get; set; }
        public string UseGroupAsViewingGroup { get; set; }
        public bool? UseGroupAsViewingGroupTmp { get; set; }
        public string BaseOrderInMfgPlan { get; set; }
        public string ConsolidateResByStdTypeUi { get; set; }
        public bool? ConsolidateResByStdType { get; set; }
        public int? RowVersion { get; set; }
        public int? TableVersion { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public string UserChar1 { get; set; }
        public string UserChar2 { get; set; }
        public string UserChar3 { get; set; }
        public string UserChar4 { get; set; }
        public string UserChar5 { get; set; }
        public string UserChar6 { get; set; }
        public DateTime? UserDate1 { get; set; }
        public DateTime? UserDate2 { get; set; }
        public DateTime? UserDate3 { get; set; }
        public DateTime? UserDate4 { get; set; }
        public DateTime? UserDate5 { get; set; }
        public DateTime? UserDate6 { get; set; }
        public decimal? UserDecimal1 { get; set; }
        public decimal? UserDecimal2 { get; set; }
        public decimal? UserDecimal3 { get; set; }
        public decimal? UserDecimal4 { get; set; }
        public decimal? UserDecimal5 { get; set; }
        public decimal? UserDecimal6 { get; set; }
        public decimal? UserDecimal7 { get; set; }
        public decimal? UserDecimal8 { get; set; }
        public decimal? UserDecimal9 { get; set; }
        public decimal? UserDecimal10 { get; set; }
        public decimal? UserDecimal11 { get; set; }
        public decimal? UserDecimal12 { get; set; }
        public int? UserInteger1 { get; set; }
        public int? UserInteger2 { get; set; }
        public int? UserInteger3 { get; set; }
        public int? UserInteger4 { get; set; }
        public int? UserInteger5 { get; set; }
        public int? UserInteger6 { get; set; }

        public virtual ICollection<EsCutting> EsCutting { get; set; }
        public virtual ICollection<EsFinishing> EsFinishing { get; set; }
        public virtual ICollection<EsFolding> EsFolding { get; set; }
        public virtual ICollection<EsGroups> EsGroups { get; set; }
        public virtual ICollection<EsInk> EsInk { get; set; }
        public virtual ICollection<EsPlate> EsPlate { get; set; }
        public virtual ICollection<EsPrepress> EsPrepress { get; set; }
        public virtual ICollection<EsPress> EsPress { get; set; }
        public virtual ICollection<EsStock> EsStock { get; set; }
    }
}