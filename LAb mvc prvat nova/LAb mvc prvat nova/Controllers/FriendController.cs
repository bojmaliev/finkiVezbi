using LAb_mvc_prvat_nova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAb_mvc_prvat_nova.Controllers
{
    public class FriendController : Controller
    {
        public FriendDB _db = new FriendDB();
        // GET: Friend
        public ActionResult Index(string sortOrder, string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "ime_desc" : "";
            var friends = _db.Friends.Select(t=>t);
            if (!String.IsNullOrEmpty(searchString)) {
                friends = friends.Where(s=> s.Ime.Contains(searchString) || s.MestoZiveenje.Contains(searchString));   
            }
            switch (sortOrder) {
                case "ime_desc":
                    friends = friends.OrderByDescending(a=> a.Ime);
                    break;

                default:
                    friends = friends.OrderBy(a=> a.Ime);
                    break;
            }

            return View(friends.ToList());
        }

        // GET: Friend/Details/5
        public ActionResult Details(int id = 0)
        {
            var model = _db.Friends.Find(id);
            if (model == null) return HttpNotFound();
            return View(model);
        }

        // GET: Friend/Create
        public ActionResult Create()
        {
            var model = new FriendModel();
            return View(model);
        }

        // POST: Friend/Create
        [HttpPost]
        public ActionResult Create(FriendModel model)
        {
            if (ModelState.IsValid) {
                _db.Friends.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else{
                
                return View();
            }
        }

        // GET: Friend/Edit/5
        public ActionResult Edit(int id=0)
        {
            var model = _db.Friends.Find(id);
            if (model == null) return HttpNotFound();
            return View(model);
        }

        // POST: Friend/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var model = _db.Friends.Find(id);
            if (TryUpdateModel(model)) {
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        // GET: Friend/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var model = _db.Friends.Find(id);
            _db.Friends.Remove(model);
            _db.SaveChanges();
            return new EmptyResult();
        }
        protected override void Dispose(bool disposing)
        {
            if (_db != null) {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
