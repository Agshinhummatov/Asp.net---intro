using Microsoft.AspNetCore.Mvc;

namespace Tasks.Controllers
{
    public class CalculateController : Controller
    {
        public IActionResult Index()
        {
            int a = 0;
            int b = 1;
            int[] fibNumbers = new int[20];
            fibNumbers[0] = a;
            fibNumbers[1] = b;
            for (int i = 2; i < 20; i++)
            {
                int c = a + b;   
                a = b;  
                b = c;  
                fibNumbers[i] = c;
            }

            return View(fibNumbers);
        }



        

    }
}
