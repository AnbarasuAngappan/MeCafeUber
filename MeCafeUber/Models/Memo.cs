using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MeCafeUber.Models
{
    public class Memo
    {
        public int ID { get; set; }
      //  public bool Worked { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Priority { get; set; }

        [Display(Name = "Rep")]
        public string Rip { get; set; }

        public string Type { get; set; }
        public string Action { get; set; }
        public string ActionDescription { get; set; }
        [Display(Name = "Amount")]
        public string Account { get; set; }
        public string CardNumber { get; set; }
        public string PlanNumber { get; set; }
        public string SequenceNumber { get; set; }
        public string CaseNumber { get; set; }
        public string StoreNumber { get; set; }
        public string Remarks { get; set; }
    }
}