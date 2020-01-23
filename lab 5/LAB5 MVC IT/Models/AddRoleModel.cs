using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LAB5_MVC_IT.Models
{
    public class AddRoleModel
    {
        public string SelectedRole { get; set; }
        public List<string> Roles { get; set; }
        public string Email { get; set; }
    }
}