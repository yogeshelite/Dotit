using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImprojectCommit
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ProjectId { get; set; }
        public string Projectdesc { get; set; }
        public bool Projectactive { get; set; }
        public string ProjectPhaseId { get; set; }
        public string ProjectPhaseDesc { get; set; }
        public string ProjectPhaseStatus { get; set; }
        public DateTime? ProjectPhaseStartDate { get; set; }
        public DateTime? ProjectPhaseDueDate { get; set; }
        public DateTime? ProjectPhaseCompDate { get; set; }
        public decimal Projectphasepercomp { get; set; }
        public string Linecode { get; set; }
        public string Linegroupanalysiscode { get; set; }
        public string Linegroupanalysisdesc { get; set; }
        public string Linedetailanalysiscode { get; set; }
        public string Linedetailanalysisdesc { get; set; }
        public string Jobnum { get; set; }
        public bool Jobcomplete { get; set; }
        public int Operationseq { get; set; }
        public string Operationworkcenter { get; set; }
        public string Operationworkcenterdesc { get; set; }
        public string Operationopcode { get; set; }
        public string Operationopdesc { get; set; }
        public DateTime? Operationstartdate { get; set; }
        public DateTime? Operationenddate { get; set; }
        public int Assemblyseq { get; set; }
        public string Assemblypart { get; set; }
        public string Assemblydesc { get; set; }
        public string Materialpart { get; set; }
        public string Materialdesc { get; set; }
        public int Materialseq { get; set; }
        public string Materialprodgrp { get; set; }
        public string Materialprodgrpdesc { get; set; }
        public DateTime? Materialdatereq { get; set; }
        public string Materialclass { get; set; }
        public string Materialclassdesc { get; set; }
        public decimal Materialqtyper { get; set; }
        public bool Materialfixedqty { get; set; }
        public decimal Materialqtyrequired { get; set; }
        public int Materiallinkedoperation { get; set; }
        public bool Materialbackflush { get; set; }
        public int Vendornum { get; set; }
        public string Vendorid { get; set; }
        public string Vendorname { get; set; }
        public string Vendorpart { get; set; }
        public int Ponum { get; set; }
        public int Poline { get; set; }
        public int Porelease { get; set; }
        public string PoapprvalStatus { get; set; }
        public string Pobuyer { get; set; }
        public DateTime? Popromisedate { get; set; }
        public DateTime? Poduedate { get; set; }
        public decimal Poourqty { get; set; }
        public decimal Povendorqty { get; set; }
        public decimal Poconvfactor { get; set; }
        public string PocurrencyCode { get; set; }
        public decimal Pocurrencyexchangerate { get; set; }
        public bool Pocurrencylock { get; set; }
        public string Pouom { get; set; }
        public decimal Pounitdomesticcost { get; set; }
        public decimal Pounitcurrencycost { get; set; }
        public decimal Poreceivedqty { get; set; }
        public decimal Povendoroustgqty { get; set; }
        public decimal Poouroustgqty { get; set; }
        public decimal Podomesticoustgvalue { get; set; }
        public decimal Pocurrencyoustgvalue { get; set; }
        public DateTime? Builddate { get; set; }
        public string PoconvFactorDirection { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
