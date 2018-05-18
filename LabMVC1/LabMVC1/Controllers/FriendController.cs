using LabMVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabMVC1.Controllers
{
    public class FriendController : Controller
    {
        public static List<FriendModel> friends = new List<FriendModel>() {
            new FriendModel(1, "Martin", "Negorci"),
            new FriendModel(2, "Kire", "Gevgelija")
        };
        // GET: Friend
        public ActionResult Index()
        {
            return View(friends);
        }
        public ActionResult Edit(int id) {
            var friend = friends.ElementAt(id);
            return View(friend);
        }
    }
}