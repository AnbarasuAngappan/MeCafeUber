using MeCafeUber.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using System.Text;

namespace MeCafeUber.Controllers
{
    public class MecafeController : Controller
    {
        private ApplicationDbContext applicationDbContext = new ApplicationDbContext();
        // GET: Mecafe

        public string _Account;

        public ActionResult EmptyIndex()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Queue(int ? page)
        {
            return View(applicationDbContext.ManualQueueContext.ToList().ToPagedList(page ?? 1,25));
        }


        [HttpGet]
        public ActionResult CustAccountSearch()
        {
            return View();
        }

        [HttpPost]
        public ActionResult QueueItem()
        {

            string principle = Convert.ToString(Request["txtAmount"].ToString());
            var Que = applicationDbContext.customerAccountSearches.Where(q => q.AccountNumber == principle).ToList();
            return View(Que);

            #region
            // decimal principle = Convert.ToDecimal(Request["txtAccountNumber"].ToString());

            // var redirectUrl = new UrlHelper(Request.RequestContext).Action("QueueItem", "Mecafe", new { });
            //// _Account = Id;
            // try
            // {               

            //     // var Que = applicationDbContext.ManualQueueContext.Where(E => E.AccountNumber == Id).ToList().ToPagedList(1, 25);
            //    // var Que = applicationDbContext.ManualQueueContext.Where(q => q.AccountNumber == Id).ToList();
            //     //return View("Queue",Que);
            //     //return View(Que);
            //     ViewBag.X = _Account;

            // }
            // catch (Exception e)
            // {
            //     return Json(new { Url = redirectUrl, status = "Error" });
            //     throw new Exception(e.Message);

            // }
            // return Json(new { Url = redirectUrl, status = "OK" });
            #endregion

        }


        public ActionResult Memo()
        {
            var memo = applicationDbContext.memos.OrderByDescending(E=>E.ID).ToList();
           return  View(memo);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost, ActionName("Create")]
        public ActionResult CreatePost()//[Bind(Include = "EmployeeID,EmployeeName,EmployeeAge,EmployeeGender,EmployeeCity,EmpDepartmentID,DepartmentID")] Employee employee
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Memo employee = new Memo();
                    TryUpdateModel<Memo>(employee); //UpdateModel<Employee>(employee); -> this Throws the Exception when the validation fails(UpdateViewModel)
                    //This Function inspects all the HttpRequest such as posted form data, 
                    //querry string, cookies and server variables and populate in the Employee Object.
                    applicationDbContext.memos.Add(employee);
                    applicationDbContext.SaveChanges();
                    return RedirectToAction("Memo");
                }
                return View();
            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}