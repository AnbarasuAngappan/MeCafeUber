using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeCafeUber.Models
{
    public class ManualQueue
    {
        public int ID { get; set; }
        public bool Worked { get; set; }
        public string AccountNumber { get; set; }
        public string AccountHoldername { get; set; }
        public string Balance { get; set; }
        public string DelinquentAmount { get; set; }
        public string PaymentAmount { get; set; }
        public string NextWorkDate { get; set; }
        public string OverLimitAmount { get; set; }
        public string CyclesDelinquent { get; set; }
        public string DaysPastDue { get; set; }
        public string NoofBrokenPTP { get; set; }
        public string FuturePromiseDate { get; set; }
    }
}