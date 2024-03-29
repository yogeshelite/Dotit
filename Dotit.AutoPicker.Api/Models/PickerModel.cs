using System;
namespace DotIt.AutoPickerApi.Models
{
    public class AuthenticateModel
    {
        public string UserName { get; internal set; }
        public string Password { get; internal set; }
    }
    public class PickerModel
    {
        public Nullable<System.Guid> EmpID { get; set; }
        public string Company { get; set; }
        public string DcdUserID { get; set; }
        public string Name { get; set; }
        public string EMailAddress { get; set; }
        public string Grouplist { get; set; }
       // public int? PickerType { get; set; }
        public int? MaxLines { get; set; }
        public int? MaxWeight { get; set; }
        public int? AdminlineperHour { get; set; }
        public string Password { get; set; }
        public bool? Active { get; set; }
        public Nullable<DateTime> LastLogin { get; set; }
        public Nullable<DateTime> RecordDate { get; set; }
        public string UserHeight { get; set; }
        public int? WeightCapacity { get; set; }
       
        public string PickForCompany { get; set; }
        public bool Ncco { get; set; }
        public bool Dirf { get; set; }
        public int? MaxOrder { get; set; }
    }
}