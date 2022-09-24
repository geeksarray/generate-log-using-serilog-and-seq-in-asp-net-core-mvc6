using ASPNETCoreMVCSerilog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace ASPNETCoreMVCSerilog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            //_logger.LogInformation("Index from HomeController called"); 
            //Customer customer = new Customer();
            //customer.CustomerID = 1;
            //customer.CustomerName = "Scott";
            //_logger.LogInformation("Processing {@customer}", customer);
            //int id = -1;
            //try
            //{
            //    if (id <= 0)
            //    {
            //        throw new Exception($"id cannot be less than or equal to 0:{id}");
            //    }

            //    return Ok($"id is:{id}");

            //}
            //catch (Exception ex)
            //{
            //    var sb = new StringBuilder();
            //    sb.AppendLine($"Error message:{ex.Message}");
            //    sb.AppendLine($"Error stack trace:{ex.StackTrace}");
            //    //_logger.LogError(sb.ToString());
            //    _logger.LogError(ex, sb.ToString());
            //}
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}