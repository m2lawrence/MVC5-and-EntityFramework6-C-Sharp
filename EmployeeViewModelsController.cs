using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCEmployeeViewModel1.Models;

namespace MVCEmployeeViewModel1.Controllers
{
    public class EmployeeViewModelsController : Controller
    {
        private mikeEntities db = new mikeEntities();

        // GET: EmployeeViewModels
        public ActionResult Index()
        {
            return View(db.EmployeeViewModels.ToList());
        }

        // GET: EmployeeViewModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeViewModel employeeViewModel = db.EmployeeViewModels.Find(id);
            if (employeeViewModel == null)
            {
                return HttpNotFound();
            }
            return View(employeeViewModel);
        }

        // GET: EmployeeViewModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeID,Name,DepartmentID,Address,DepartmentName,Remember")] EmployeeViewModel employeeViewModel)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeViewModels.Add(employeeViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeViewModel);
        }

        // GET: EmployeeViewModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeViewModel employeeViewModel = db.EmployeeViewModels.Find(id);
            if (employeeViewModel == null)
            {
                return HttpNotFound();
            }
            return View(employeeViewModel);
        }

        // POST: EmployeeViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeID,Name,DepartmentID,Address,DepartmentName,Remember")] EmployeeViewModel employeeViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeViewModel);
        }

        // GET: EmployeeViewModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeViewModel employeeViewModel = db.EmployeeViewModels.Find(id);
            if (employeeViewModel == null)
            {
                return HttpNotFound();
            }
            return View(employeeViewModel);
        }

        // POST: EmployeeViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeViewModel employeeViewModel = db.EmployeeViewModels.Find(id);
            db.EmployeeViewModels.Remove(employeeViewModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
