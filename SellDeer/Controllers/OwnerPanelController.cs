using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

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

        public ActionResult CompanyInfo()
        {

            return View();
        }
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