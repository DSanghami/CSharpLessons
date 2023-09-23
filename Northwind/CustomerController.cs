using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using NWind.Models;

namespace NWind.Controllers
{
    public class CustomerController : Controller
    {

        private RepositoryCustomer _repositoryCustomer;
        public CustomerController(RepositoryCustomer customers)
        {
            _repositoryCustomer = customers;
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            List<string> customerId = _repositoryCustomer.GetAllCustomerId();
            CustomerIdViewModel idsViewModel = new CustomerIdViewModel(customerId);
            return View(idsViewModel);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(string id)
        {
            Customer customer = _repositoryCustomer.FindCustomerById(id);
            List<Order> orders = _repositoryCustomer.GetOrders(id);
            ViewData["order"] = orders;
            return View(customer);
        }


        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
