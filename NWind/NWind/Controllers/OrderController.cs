using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NWind.Models;

namespace NWind.Controllers
{

    public class OrderController : Controller
    {

        private RepositoryOrders _repositoryOrders;
        public OrderController(RepositoryOrders orders)
        {
            _repositoryOrders = orders;
        }


           // GET: OrderController
        public ActionResult Index()
        {
            //order.OrderSelectView = new List<SelectListItem>();
            //foreach (var list in order.Orders())
            //{
            //    order.OrderSelectView.Add(new SelectListItem(list.OrderId.ToString(), list.OrderId.ToString()));
            //}
            //return View(order);

         
                List<int> orderId = _repositoryOrders.GetAllOrderId();
                OrderIdViewModel idsViewModel = new OrderIdViewModel(orderId);
                return View(idsViewModel);
            
        }



        // GET: OrderController/Details/5
        [HttpPost]
        //public ActionResult Details(RepositoryOrders orderRep)
        //{
        //    Order orders = order.FindOrderById(orderRep.SelectedId);
        //    return View(orders);
        //}




        // GET: OrderController/Create
        public ActionResult Create()
        {
            return View();
        }



        // POST: OrderController/Create
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



        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }



        // POST: OrderController/Edit/5
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



        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }



        // POST: OrderController/Delete/5
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

    



        