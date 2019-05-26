using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using SellDeer.DataModel;
using System.Data.Entity.Validation;

namespace SellDeer.Controllers
{
    //[Authorize(Roles ="admin")]
    public class OwnerPanelController : Controller
    {
        
        // GET: OwnerPanel
        public ActionResult Index()
        {
            
            return View();
        }

        #region company info
        [HttpGet]
        public ActionResult CompanyInfo()
        {
            ShopM shop = new ShopM();
            Company exist = shop.Company.Where(c => c.lang == "EN").FirstOrDefault();
            return View(exist);
        }

        [HttpPost]
        public ActionResult CompanyInfo(string txtcompanyName,string txtphone,string txtphone2,string txtAddress,string txtEmail,string txtAbout)
        {
            ShopM shop = new ShopM();
            Company exist = shop.Company.Where(c => c.lang == "EN").FirstOrDefault();
            if (exist!=null)
            {
                exist.address = txtAddress;
                exist.brief_discription = txtAbout;
                exist.company_name = txtcompanyName;
                exist.mail = txtEmail;
                exist.phone = txtphone;
                exist.mobile = txtphone2;
            }
            else
            {
                Company newcomp = new Company();
                newcomp.address = txtAddress;
                newcomp.brief_discription = txtAbout;
                newcomp.company_name = txtcompanyName;
                newcomp.mail = txtEmail;
                newcomp.phone = txtphone;
                newcomp.mobile = txtphone2;
                newcomp.lang = "EN";
                shop.Company.Add(newcomp);
               
            }
            shop.SaveChanges();
            exist = shop.Company.Where(c => c.lang == "EN").FirstOrDefault();
            return View(exist);
        }
        #endregion

        #region category methods

        public ActionResult Category()
        {
            ShopM shop = new ShopM();
            List<Category> lst = shop.Category.ToList();
            return View(lst);
        }
        [HttpPost]
        public ActionResult Category(string categoryName, HttpPostedFileBase inpImage)
        {
            
            try
            {
                ShopM shop = new ShopM();

                shop.Category.Add(new DataModel.Category { cat_name = categoryName,  del_flag = false, modify_user_id = 0,lang="EN" });
                shop.SaveChanges();
                List<Category> lst = shop.Category.ToList();
                
                return View(lst);
            }
            catch (DbEntityValidationException dbEx)
            {
                //code for get validation error (column name ,and error)
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
                return View();
            }
        }  

        public ActionResult editCategory( int catId,string editCategoryName, HttpPostedFileBase inpImageEdit)
        {
            ShopM shop = new ShopM();
            Category cat = shop.Category.Where(c => c.id == catId).FirstOrDefault();
            cat.cat_name = editCategoryName;
            shop.SaveChanges();
            List<Category> lst = shop.Category.ToList();
            return View("Category",lst);
        }
        public ActionResult deleteCategory(int catId)
        {
            ShopM shop = new ShopM();
            Category cat = shop.Category.Where(c => c.id == catId).FirstOrDefault();
            cat.del_flag = true;            
            shop.SaveChanges();
            List<Category> lst = shop.Category.ToList();
            Category();
            return View("Category",lst);
        }

        #endregion

        #region Brand methods
        public ActionResult Brands()
        {
            ShopM shop = new ShopM();
            List<Brand> lst = shop.Brand.ToList();
            return View(lst);
        }

        [HttpPost]
        public ActionResult Brands(string txtBrandName)
        {
                       
                ShopM shop = new ShopM();
                shop.Brand.Add(new DataModel.Brand { brand_name = txtBrandName,del_flag=false });
                shop.SaveChanges();
                List<Brand> lst = shop.Brand.ToList();

                return View(lst);           
        }


        public ActionResult editBrand(int brandId, string editBrandName)
        {
            ShopM shop = new ShopM();
            Brand bran = shop.Brand.Where(c => c.id == brandId).FirstOrDefault();
            bran.brand_name = editBrandName;
            shop.SaveChanges();
            List<Brand> lst = shop.Brand.ToList();
            return View("Brands", lst);
        }
        public ActionResult deleteBrand(int Brand)
        {
            ShopM shop = new ShopM();
            Brand bran = shop.Brand.Where(c => c.id == Brand).FirstOrDefault();
            bran.del_flag = true;
            shop.SaveChanges();
            List<Brand> lst = shop.Brand.ToList();
            Category();
            return View("Brands", lst);
        }
        #endregion

        #region subCategory methods
        public ActionResult SubCategory()
        {
            ShopM shop = new ShopM();
            List<Category> lst = shop.Category.ToList();
            ViewBag.catg = lst;
            return View();
        }

        [HttpPost]
        public ActionResult SubCategory(string txtSubcategoryName,int ddlCategForAdd)
        {

            ShopM shop = new ShopM();
            shop.SubCategory.Add(new DataModel.SubCategory { sub_cat_name = txtSubcategoryName, del_flag = false,cat_id=ddlCategForAdd,modify_user_id=0,lang="EN" });
            shop.SaveChanges();
            List<Category> lst = shop.Category.ToList();
            ViewBag.catg = lst;
            return View();
        }

        public ActionResult editSubcategory(int subId, string editSubcategoryName, int ddlCategForEdit)
        {
            ShopM shop = new ShopM();
            SubCategory catg = shop.SubCategory.Where(c => c.id == subId).FirstOrDefault();
            catg.sub_cat_name = editSubcategoryName;
            catg.cat_id = ddlCategForEdit;
            shop.SaveChanges();
            List<Category> lst = shop.Category.ToList();
            ViewBag.catg = lst;
            return View("SubCategory");
        }

        public PartialViewResult _SubCategoryList()
        {
            ShopM shop = new ShopM();
            List<Category> lst = shop.Category.Where(c=>c.id>3).ToList();
            ViewBag.catg = lst;
            return PartialView();
        }
        public ActionResult deleteSubcategory(int subId)
        {
            ShopM shop = new ShopM();
            SubCategory sub = shop.SubCategory.Where(c => c.id == subId).FirstOrDefault();
            sub.del_flag = true;
            shop.SaveChanges();
            List<Category> lst = shop.Category.Where(c => c.id > 3).ToList();
            ViewBag.catg = lst;
            return View("SubCategory");
        }

        public JsonResult getSubcategoryByCategory(int catgId) //It will be fired from Jquery ajax call  
        {
            ShopM shop = new ShopM();
            var jsonData = shop.SubCategory.Where(c => c.cat_id == catgId).ToList();
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        #endregion

        public ActionResult Offers()
        {

            return View();
        }

        public ActionResult ConfirmedOrders()
        {

            return View();
        }

        public ActionResult Orders()
        {

            return View();
        }

        public ActionResult DeliverdOrders()
        {

            return View();
        }

        #region products methods
        public ActionResult Products()
        {

            return View();
        }



        #endregion

        [HttpGet]
        public ActionResult Customers()
        {
            SqlConnection con = new SqlConnection("Server=PRINCE\\MYSQL8;Database=SellDeer;Trusted_Connection = yes; ");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from Customer", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            
            DataTable dt = new DataTable();
            con.Close();
            ad.Fill(dt);
            var fg = dt.AsEnumerable();
            var ht = dt.Rows;
            var k = ht[0].ItemArray;
            List<SellDeer.Models.modelcust> h = new List<Models.modelcust>();
            h.Add(new Models.modelcust
            {
                id = 1,
                address = "aaa",
                customer_name = "ddd",
                phone = "123"
            }
                );
            WebGrid d = new WebGrid(dt.AsEnumerable());
            var x = d.Rows[1].Value;
            ViewBag.viewCustData =h;
            
            return View();
        }
        [HttpPost]
        public ActionResult Customerspost(string custMailtxt, string custNametxt, string custUserNametxt,
            string custPhonetxt, string birthDatetxt, string custPasswordtxt, string custAddresstxt)
        {
            SqlConnection con = new SqlConnection("Server=PRINCE\\MYSQL8;Database=SellDeer;Trusted_Connection = yes; ");
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("INSERT INTO [Customer]([customer_name],[mail],[address],[phone],[del_flag])VALUES('" + custNametxt + "','" +
                custMailtxt + "','" + custAddresstxt + "','" + custPhonetxt + "','0')", con);
            cmd.ExecuteNonQuery();

            return View("Customers");
        }

        
        public ActionResult Customerss(int id)
        {

            return View("Customers");
        }
    }
}