using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeCafeUber.Models
{
    public class CustomerAccountSearch
    {
        public int ID { get; set; }
        public bool Worked { get; set; }
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string DeliqAmount { get; set; }
        public string Multiple { get; set; }
        public string RiskIndicator { get; set; }
        public string BlockCode1 { get; set; }
        public string InsuranceIndicator { get; set; }
        public string CurrentDate { get; set; }
        public string CurrentBalance { get; set; }
        public string DateLast { get; set; }        
    }
}