using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZCSAPI.BLL;
using ZCSAPI.DAL.DBModels;

namespace ZCSAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult AddProduct()
        {
            return View();
        }

        public ActionResult UploadFilesPost()
        {
            //var file = Request.Files["fileBase"];
            //string productCode = Request["productCode"].ToString().Trim();
            //string productName = Request["productName"].ToString().Trim();
            //string productDescribe = Request["productDescribe"].ToString().Trim();
            //string path = "/Upload/Images/" + Guid.NewGuid().ToString() + file.FileName;
            //Product product = new Product();
            //product.Code = productCode;
            //product.Name = productName;
            //product.Describe = productDescribe;

            //ProductImage image = new ProductImage();
            ////image.ID = 3;
            //image.Path = path;
            //image.UploadDate = System.DateTime.Now;
            //image.UploadUser = "zcs";
            //product.Image = image;

            //Store store = new Store();
            ////store.ID = 2;
            //store.Code = "zcs";
            //store.Name = "zcs";
            //store.Phone = "121212";
            //store.Products = new List<Product>();
            //store.Products.Add(product);
            //try
            //{
            //    file.SaveAs(Request.MapPath(path));
            //    ProductManager.AddProduct(product);
            //    //ProductManager.AddStore(store);
            //}
            //catch(Exception ex)
            //{
            //    throw ex;
            //}
            //return Json(new { url = path });
            return View(); 
        }
    }
}
