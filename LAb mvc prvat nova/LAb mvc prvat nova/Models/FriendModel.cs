using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LAb_mvc_prvat_nova.Models
{
    public class FriendModel
    {
        [Required(ErrorMessage = "Please add an Id")]
        [Range(0, 200, ErrorMessage = "Please enter id between 0 and 200")]
        [Display(Name = "Friend Id:")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        [Display(Name = "Friend Name")]
        public string Ime { get; set; } 
        [Required(ErrorMessage = "Please add Location")]
        [Display(Name = "Place:")]
        public string MestoZiveenje { get; set; }

        public FriendModel() {
        }
        public FriendModel(int Id, string Ime, string MestoZiveenje) {
            this.Id = Id;
            this.Ime = Ime;
            this.MestoZiveenje = MestoZiveenje;
        }

    }
}