//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EpicorDaily.Persistance.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class WAREHOUSEEMPLOYEE
    {
        public Nullable<System.Guid> EMPID { get; set; }
        public string COMPANY { get; set; }
        public string DCDUSERID { get; set; }
        public string PICKERNAME { get; set; }
        public string EMAILADDRESS { get; set; }
        public string GROUPLIST { get; set; }
        public Nullable<int> MAXLINES { get; set; }
        public Nullable<int> MAXWEIGHT { get; set; }
        public Nullable<int> ADMINLINEPERHOUR { get; set; }
        public string PASSWORD { get; set; }
        public Nullable<bool> ACTIVE { get; set; }
        public Nullable<System.DateTime> LASTLOGIN { get; set; }
        public Nullable<System.DateTime> RECORDDATE { get; set; }
        public Nullable<System.DateTime> RECORDUPDATEDATE { get; set; }
    }
}