using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webQuyTuThien.Models;

namespace webQuyTuThien.Controllers
{
    public class AccountFundController : Controller
    {
        // GET: AccountFund


        FundDataDataContext data = new FundDataDataContext();
            // GET: NguoiDung

            public ActionResult DangKy()
            {
                return View();
            }
            [HttpPost]
            public ActionResult DangKy(FormCollection collection, Account kh)
            {
                var taikhoan = collection["TaiKhoan"];
                var matkhau = collection["MatKhau"];
                var matkhauxacnhan = collection["matkhauxacnhan"];

                if (String.IsNullOrEmpty(matkhauxacnhan))
                {
                    ViewData["NhapMKXN"] = "Phải nhập mật khẩu xác nhận!";
                }
                else
                {
                    if (!matkhau.Equals(matkhauxacnhan))
                    {
                        ViewData["MatKhauGiongNhau"] = "Mat khau va mat khau xac nhan phia giong nhau;";
                    }
                    else
                    {
                        kh.TaiKhoan = taikhoan;
                        kh.MatKhau = matkhau;
                        
                        data.Accounts.InsertOnSubmit(kh);
                        data.SubmitChanges();

                        return RedirectToAction("DangNhap");
                    }
                }
                return this.DangKy();
            }
            [HttpGet]
            public ActionResult DangNhap()
            {
                return View();
            }
            [HttpPost]
            public ActionResult DangNhap(FormCollection collection)
            {
                var tendangnhap = collection["tendangnhap"];
                var matkhau = collection["matkhau"];
                Account kh = data.Accounts.SingleOrDefault(n => n.TaiKhoan == tendangnhap && n.MatKhau == matkhau);
                if (kh != null)
                {
                    ViewBag.ThongBao = "Chuc mung dang nhap thanh cong";
                    Session["TaiKhoan"] = kh;
                }
                else
                {
                    ViewBag.ThongBao = "Ten dang nhap hoac mat khau khong dung";

                }
                return RedirectToAction("listFundCustom", "Home");
            }
        }
    }
