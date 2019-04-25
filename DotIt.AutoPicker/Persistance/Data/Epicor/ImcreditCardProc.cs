using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImcreditCardProc
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ProcInterfaceCode { get; set; }
        public string ProcInterfaceDesc { get; set; }
        public string HostAddress { get; set; }
        public int HostPort { get; set; }
        public int TimeOut { get; set; }
        public string Verbosity { get; set; }
        public string ProxyAddress { get; set; }
        public int ProxyPort { get; set; }
        public string ProxyLogon { get; set; }
        public string ProxyPwd { get; set; }
        public bool AllowDepPay { get; set; }
        public bool FailDepToSalesTrans { get; set; }
        public bool FailStopsShip { get; set; }
        public bool ReauthRemaining { get; set; }
        public int DaysToRetainInfo { get; set; }
        public bool ReauthBeforePick { get; set; }
        public int ReauthAfterDays { get; set; }
        public decimal ReauthAbove { get; set; }
        public bool UseCsc { get; set; }
        public bool IgnoreCscfail { get; set; }
        public bool UseAvs { get; set; }
        public bool IgnoreAvsfail { get; set; }
        public bool IsTest { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string PayGateHostAddress { get; set; }
        public string PayGateNameSpace { get; set; }
        public string PayGatePublicKey { get; set; }
        public bool IsTraining { get; set; }
    }
}
