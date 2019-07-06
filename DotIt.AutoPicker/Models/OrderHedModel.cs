using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotIt.AutoPicker.Models
{
    public class OrderHedModel
    {
        //OrderNum(integer, optional),
        public int OrderNum { get; set; }
        public string OrderComment { get; set; }
        

        //CustNum(integer, optional),
        public int CustNum { get; set; }

        //NeedByDate (string, optional),
        public string NeedByDate { get; set; }

        //ReservePriorityCode (string, optional),
        public string ReservePriorityCode { get; set; }

        //TotalLines(integer, optional),
        public int TotalLines { get; set; }

        //PONum (string, optional),
        public string PONum { get; set; }

        //OrderDate (string, optional),
        public string OrderDate { get; set; }

        //RequestDate (string, optional),
        public string RequestDate { get; set; }

        //PickListComment (string, optional),
        public string PickListComment { get; set; }

        //AllocPriorityCode (string, optional),
        public string AllocPriorityCode { get; set; }

        //DoNotShipAfterDate (string, optional),
        public string DoNotShipAfterDate { get; set; }

        //DoNotShipBeforeDate (string, optional),
        public string DoNotShipBeforeDate { get; set; }

        //metadata field for the response from API
        public string value { get; set; }

        // field for OrderDate in DateTime Format
        public DateTime OrderDateTime { get; set; }

        //Company (string, optional),
        public string Company { get; set; }

        //OrderLine (integer, optional),
        public string OrderLine { get; set; }

        //LineType (string, optional),
        public string LineType { get; set; }

        //OrderQty (number, optional),
        public string OrderQty { get; set; }

        //LineStatus (string, optional),
        public string LineStatus { get; set; }

        //ShipBoxNumber_c (integer, optional),
        public int ShipBoxNumber_c { get; set; }

        //BoxWeight_c (number, optional),
        public float BoxWeight_c { get; set; }

        //NetWeight_c (number, optional),
        public float NetWeight_c { get; set; }

        //OriginalOrderLine_c (string, optional),
        public string OriginalOrderLine_c { get; set; }

        //Feild used for storing Orderline Picked Checked status
        public bool OrderLinePickedUp { get; set; }

        //Field for storing Status of a order
        public string OrderPickStatus { get; set; }

        //Field for storing Pick Date Time
        public string PickTime { get; set; }

        //Field for storing UserId
        public int UserId { get; set; }

        //Field for Bin location
        public string BinNum { get; set; }
        
        //Field for SKU
        public string PartNum { get; set; }

        //Field for Description
        public string LineDesc { get; set; }
    }
}
