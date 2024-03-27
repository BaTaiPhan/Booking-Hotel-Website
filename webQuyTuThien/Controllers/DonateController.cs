using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webQuyTuThien.Models;

namespace webQuyTuThien.Controllers
{
    public class DonateController : Controller
    {
        // GET: Donate
        FundDataDataContext data = new FundDataDataContext();
        
        
        public ActionResult XacNhanThanhCong()
        {
            return View();
        }
        public ActionResult Donation(Donate s)
        {
            return View(s);
        }
        [HttpPost]
        public ActionResult Donation(FormCollection collection, Donate d,Fund f)
        {
            var E_name = collection["name"];
            var E_congratulation = collection["congratulation"];  
            var E_amount = Convert.ToInt32(collection["amount"]);
            if (string.IsNullOrEmpty(E_name))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                d.name = E_name.ToString();
                d.congratulation = E_congratulation.ToString();
                d.amount = E_amount;
                data.Donates.InsertOnSubmit(d);
                data.SubmitChanges();
                return RedirectToAction("XacNhanThanhCong");
            }
            return this.Donation(d);
        }
    }
}