using System.Linq;
using System.Web.Mvc;
using MVCAssessment.Models;
namespace MVCAssessment.Controllers
{
    public class CodeController : Controller
    {

        northwindEntities db = new northwindEntities();

        public ActionResult Index()

        {

            return View();

        }

        public ActionResult Customers()

        {

            var customer1 = db.Customers.Where(c => c.Country == "Germany").ToList();

            return View(customer1);

        }

        public ActionResult CustomerOfOrderID()

        {

            var customer2 = db.Orders.Where(o => o.OrderID == 10248).Select(o => o.Customer).FirstOrDefault();

            return View(customer2);

        }

    }

}
