using System;
using System.Collections.Generic;
using System.Linq;
using PagedList;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using webQuyTuThien.Models;
using System.Configuration;
using Newtonsoft.Json.Linq;

namespace webQuyTuThien.Controllers
{
    public class HomeController : Controller
    {
        FundDataDataContext data = new FundDataDataContext();
        public ActionResult Index(int? page)
        {
            if (page == null) page = 1;
            var all_sach = (from s in data.Funds select s).OrderBy(m => m.id);
            int pageSize = 1;
            int pageNum = page ?? 1;
            return View(all_sach.ToPagedList(pageNum, pageSize));
        }

        public ActionResult About()
        {
            var all_fund = from ss in data.Funds select ss;
            return View(all_fund);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult listFundCustom()
        {
            var all_fund = from ss in data.Funds select ss;
            return View(all_fund);
        }
        public ActionResult Detail(int id)
        {
            var D_fund = data.Funds.Where(m => m.id == id).First();
            return View(D_fund);
        }
        /*public ActionResult Donation()
        {
            string endpoint = ConfigurationManager.AppSettings["endpoint"].ToString();
            string partnerCode = ConfigurationManager.AppSettings["partnerCode"].ToString();
            string accessKey = ConfigurationManager.AppSettings["accessKey"].ToString();
            string serectKey = ConfigurationManager.AppSettings["serectKey"].ToString();
            string orderInfo = "DH" + DateTime.Now.ToString("yyyyMMDDHHmmss");
            string returnUrl = ConfigurationManager.AppSettings["returnUrl"].ToString();
            string notifyUrl = ConfigurationManager.AppSettings["notifyUrl"].ToString();


            string orderId = Guid.NewGuid().ToString();
            string requestId = Guid.NewGuid().ToString();
            string extraData = "";

            string rawHash = "partnerCode=" + partnerCode
                + "&accessKey=" + accessKey
                + "&requestId=" + requestId
                + "&orderId=" + orderId
                + "&orderInfo=" + orderInfo
                + "&returnUrl=" + returnUrl
                + "&notifyUrl=" + notifyUrl
                + "&extraData=" + extraData;
            MoMoSecurity crypto = new MoMoSecurity();
            string signature = crypto.Sign(rawHash, serectKey);
            JObject message = new JObject()
            {
                { "partnerCode",partnerCode},
                { "accessKey",accessKey},
                { "requestId",requestId},
                { "orderId",orderId},
                { "returnUrl",returnUrl},
                { "notifyUrl",notifyUrl},
                { "requestType","captureMoMoWallet"},
                { "signature",signature }
            };
            string responeFormMoMo = PaymentRequest.sendPaymentRequest(endpoint, message.ToString());
            JObject jmessage = JObject.Parse(responeFormMoMo);

            return Redirect(jmessage.GetValue("payUrl").ToString());
        }*/
    }
}