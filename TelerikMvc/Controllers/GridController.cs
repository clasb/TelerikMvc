using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessModel;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace TelerikMvc.Controllers
{
    public class GridController : Controller
    {

        private EntitiesModel dbContext;

        protected override void Initialize(System.Web.Routing.RequestContext requestcontext)
        {
            base.Initialize(requestcontext);
            this.dbContext = ContextFactory.GetContextPerRequest();
        }
        // GET: Grid
        public ActionResult Index()
        {
            //ViewBag.Customers = dbContext.Customers;
            return View(this.dbContext.Customers.ToList());
        }

        [HttpPost]
        public ActionResult Customers_Read([DataSourceRequest] DataSourceRequest request)
        {
            using (var db = new EntitiesModel())
            {
                IQueryable<Customer> customers = db.Customers;
                DataSourceResult result = customers.ToDataSourceResult(request);
                return Json(result);
            }
        }
        // GET: Grid/Details/5
        public ActionResult Details(int id)
        {
            return View(this.dbContext.Customers.FirstOrDefault(customer => customer.IdCustomer == id));
        }

        // GET: Grid/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Grid/Create
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                // TODO: Add insert logic here
                this.dbContext.Add(customer);
                this.dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Grid/Edit/5
        public ActionResult Edit(int id)
        {
            return View(this.dbContext.Customers.FirstOrDefault(customer => customer.IdCustomer == id));
        }

        // POST: Grid/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Customer customerToUpdate)
        {
            try
            {
                // TODO: Add update logic here
                Customer originalCustomer =
                    this.dbContext.Customers.FirstOrDefault(customer => customer.IdCustomer == id);
                originalCustomer.Name = customerToUpdate.Name;
                this.dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Grid/Delete/5
        public ActionResult Delete(int id)
        {
            return View(this.dbContext.Customers.FirstOrDefault(customer => customer.IdCustomer == id));
        }

        // POST: Grid/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Customer customerToDelete =
                    this.dbContext.Customers.FirstOrDefault(customer => customer.IdCustomer == id);
                this.dbContext.Delete(customerToDelete);
                this.dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
