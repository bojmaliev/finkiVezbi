using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabMVC1.Models
{
    public class FriendModel
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string MestoZiveenje { get; set; }
        public FriendModel(int Id, string Ime, string MestoZiveenje) {
            this.Id = Id;
            this.Ime = Ime;
            this.MestoZiveenje = MestoZiveenje;
        }
    }
}