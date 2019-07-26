using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.DotitPicker
{
    public partial class Warehouseemployee
    {
        public int Empid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public bool Pickncco { get; set; }
        public bool Pickdotit { get; set; }
        public int Maxlines { get; set; }
        public int Maxweight { get; set; }
        public int Adminlineperhour { get; set; }
    }
}
