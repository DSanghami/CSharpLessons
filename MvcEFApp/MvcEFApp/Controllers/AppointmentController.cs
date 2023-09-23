using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcEFApp.Models;
using System.Numerics;

namespace MvcEFApp.Controllers
{   
    public class AppointmentController : Controller
    {
        public ActionResult Index()
        {
            List<Appointment> appointments = RepositoryAppointment.GetAppointment();
            if (appointments != null && appointments.Count > 0)



                return View(appointments);
            else
                return RedirectToAction("Create");
        }

        // GET: DoctorController/Details/5
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            Appointment appointment = RepositoryAppointment.GetAppointmentById(id);
            return View(appointment);
        }

        // GET: DoctorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoctorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Appointment pappointment)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryAppointment.AddNewAppointment(pappointment);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception err)
            {
                return View();
            }
        }

        // GET: DoctorController/Edit/5
        public ActionResult Edit(int id)
        {

            Appointment appointment = RepositoryAppointment.GetAppointmentById(id);
            return View(appointment);

        }

        // POST: DoctorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, Appointment appointment)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryAppointment.ModifyAppointment(appointment);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DoctorController/Delete/5
        public ActionResult Delete(int id)
        {
            Appointment appointment = RepositoryAppointment.GetAppointmentById(id);
            return View(appointment);
        }

        // POST: DoctorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryAppointment.RemoveAppointment(id);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
