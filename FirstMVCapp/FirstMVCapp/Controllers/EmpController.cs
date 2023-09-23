using FirstMVCapp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace FirstMVCapp.Controllers
{
    public class EmpController : Controller
    {
        // GET: EmpController
        public ActionResult Index()
        {
            List<EmpTable> empLost = EmpDbRepositorycs.GetEmpList();
            return View(empLost);

        }

        // GET: EmpController/Details/5
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            EmpTable emp = EmpDbRepositorycs.GetEmpById(id);
            return View(emp);
        }

        // GET: EmpController/Create
        public ActionResult Create()
        {
            EmpTable emp = new EmpTable();
            return View(emp);

        }

        // POST: EmpController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, EmpTable pEmp)
        {
            try
            { 
                if (ModelState.IsValid)
                {
                    EmpDbRepositorycs.AddNewEmp(pEmp);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: EmpController/Edit/5
        public ActionResult Edit(int id)
        {
            
            if (id <= 0)
            {



                return RedirectToAction("Index");
            }
            EmpTable emp = EmpDbRepositorycs.GetEmpById(id);
            return View(emp);
        }

        // POST: EmpController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, EmpTable pEmp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmpDbRepositorycs.UpdateEmp(pEmp);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }



            EmpTable emp = EmpDbRepositorycs.GetEmpById(id);
            return View(emp);
        }

        // POST: EmpController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            if (ModelState.IsValid)
            {
                EmpDbRepositorycs.DeletEmp(id);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
