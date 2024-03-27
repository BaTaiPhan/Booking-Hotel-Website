
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webQuyTuThien.Models;



namespace webQuyTuThien.Controllers
{
    public class FundController : Controller
    {
        FundDataDataContext data = new FundDataDataContext();
        // GET: Fund
        public ActionResult listFundAD()
        {
            var all_fund = from ss in data.Funds select ss;
            return View(all_fund);
        }
        public ActionResult Detail(int id,Donate d,Fund f)
        {
            f.full_amount = 0;
            var D_fund = data.Funds.Where(m => m.id == id).First();
            f.full_amount = f.full_amount + d.amount;
            return View(D_fund);
        }
        public ActionResult Create(Fund s)
        {
            return View(s);
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection, Fund s)
        {
            var E_name = collection["name"];
            var E_description = collection["description"];
            var E_content = collection["content"];
            var E_hinh = collection["hinh"];
            var E_kq = Convert.ToInt32(collection["expected_result"]);
            var E_status = collection["status"];
            var E_created_date = Convert.ToDateTime(collection["created_date"]);
            var E_end_date = Convert.ToDateTime(collection["end_date"]);
            if (string.IsNullOrEmpty(E_name))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                s.name = E_name.ToString();
                s.description = E_description.ToString();
                s.content = E_content.ToString();
                s.hinh = E_hinh.ToString();
                s.expected_result = E_kq;
                s.created_date = E_created_date;
                s.end_date = E_end_date;
                data.Funds.InsertOnSubmit(s);
                data.SubmitChanges();
                return RedirectToAction("ListFundAD");
            }
            return this.Create(s);
        }
        public ActionResult Edit(int id)
        {
            var E_sach = data.Funds.First(m => m.id == id);
        
            return View(E_sach);
        }
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var E_fund = data.Funds.First(m => m.id == id);
            var E_name = collection["name"];
            var E_description = collection["description"];
            var E_content = collection["content"];
            var E_hinh = collection["hinh"];
            var E_kq = Convert.ToInt32(collection["expected_result"]);
            var E_status = collection["status"];
            var E_created_date = Convert.ToDateTime(collection["created_date"]);
            var E_end_date = Convert.ToDateTime(collection["end_date"]);

            E_fund.id = id;
            if (string.IsNullOrEmpty(E_name))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                E_fund.name = E_name;
                E_fund.description = E_description;
                E_fund.content = E_content;
                E_fund.hinh = E_hinh;
                E_fund.expected_result = E_kq;
                E_fund.status = E_status;
                E_fund.created_date = E_created_date;
                E_fund.end_date = E_end_date;
 
                UpdateModel(E_fund);
                data.SubmitChanges();
                return RedirectToAction("ListFundAD");
            }
            return this.Edit(id);
        }
        
        public ActionResult Delete(int id)
        {
            var D_sach = data.Funds.First(m => m.id == id);
            return View(D_sach);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var D_sach = data.Funds.Where(m => m.id == id).First();
            data.Funds.DeleteOnSubmit(D_sach);
            data.SubmitChanges();
            return RedirectToAction("ListFundAD");

        }
        public string ProcessUpload(HttpPostedFileBase file)
        {
            if (file == null)
            {
                return "";
            }
            file.SaveAs(Server.MapPath("~/Content/images/" + file.FileName));
            return "/Content/images/" + file.FileName;
        }
    }
}