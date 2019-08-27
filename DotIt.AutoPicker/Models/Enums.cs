using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotIt.AutoPicker.Models
{
    public class Enums
    {
        public enum Status {
            
            Picked=0,
            UnPicked=1,
            Quarentine=2,
            Replenish=3,
            InventoryControl=4 ,
            Hold=5,Pending=6 };
        public enum OrderStatus {
            Hold =0,
            Complete=1,
            Pending =2 };
    }
}
