using Microsoft.AspNetCore.Mvc;

namespace Asp_intro.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            int[] nums1 = {1,2,3,4,5};
            int[] nums2 = { 10, 2, 30, 4, 50 };

            Data data = new Data();
            data.Nums1= nums1;
            data.Nums2= nums2;

            return View(data);
        }

        //public string Index(int id)
        //{
        //    if (id== 0)
        //    {
        //        return "Aqshin";

        //    }
           
        //    return "Aqshin - " + id;

        //}

        //public string Detail(string sulg, string name )
        //{

        //    return sulg + " " + name;
        //}

        //private string GetName()
        //{
        //    return "Aqshin";
        //}


    }

    class Data
    {
        public int [] Nums1 { get; set; }
        public int[] Nums2 { get; set; }
    }
}
