using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LAB5_MVC_IT.Models;

namespace LAB5_MVC_IT.Controllers
{
    public class FriendController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Friend
        [Authorize(Roles = "User,Manager,Administrator")]
        public ActionResult Index()
        {
            return View(db.FriendModels.ToList());
        }

        // GET: Friend/Details/5
        [Authorize(Roles = "User,Manager,Administrator")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FriendModel friendModel = db.FriendModels.Find(id);
            if (friendModel == null)
            {
                return HttpNotFound();
            }
            return View(friendModel);
        }

        // GET: Friend/Create
        [Authorize(Roles = "User,Manager,Administrator")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Friend/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Ime,MestoZiveenje")] FriendModel friendModel)
        {
            if (ModelState.IsValid)
            {
                db.FriendModels.Add(friendModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(friendModel);
        }

        // GET: Friend/Edit/5
        [Authorize(Roles = "Manager,Administrator")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FriendModel friendModel = db.FriendModels.Find(id);
            if (friendModel == null)
            {
                return HttpNotFound();
            }
            return View(friendModel);
        }

        // POST: Friend/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Ime,MestoZiveenje")] FriendModel friendModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(friendModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(friendModel);
        }

        // GET: Friend/Delete/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FriendModel friendModel = db.FriendModels.Find(id);
            if (friendModel == null)
            {
                return HttpNotFound();
            }
            return View(friendModel);
        }

        // POST: Friend/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FriendModel friendModel = db.FriendModels.Find(id);
            db.FriendModels.Remove(friendModel);
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
