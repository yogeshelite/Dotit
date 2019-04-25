using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImuserComp
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string DcdUserId { get; set; }
        public string Company { get; set; }
        public string CurPlant { get; set; }
        public string PlantList { get; set; }
        public string PrimBuyerId { get; set; }
        public string Name { get; set; }
        public int OverloadInfHeight { get; set; }
        public string OverloadInfSort { get; set; }
        public string PrimSalesRepId { get; set; }
        public bool StartTaskSaleRepWb { get; set; }
        public bool StartTaskOppEnt { get; set; }
        public bool StartOppSaleRepWb { get; set; }
        public bool StartOrdSaleRepWb { get; set; }
        public bool StartRmasaleRepWb { get; set; }
        public bool StartScallSaleRepWb { get; set; }
        public string WorkstationId { get; set; }
        public bool CalcFulfillOnSearch { get; set; }
        public string EmpId { get; set; }
        public bool CalcQtysPreference { get; set; }
        public bool CanUpdateExpense { get; set; }
        public bool CanUpdateTime { get; set; }
        public string PayrollMgr { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool FwblimitedRefresh { get; set; }
        public bool FwbuseDemandWhseOnly { get; set; }
        public bool SharedSupValidation { get; set; }
        public int TransactionRetrievalDays { get; set; }
    }
}
