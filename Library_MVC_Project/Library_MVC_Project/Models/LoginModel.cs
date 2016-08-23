using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library_MVC_Project.Models
{
    public class LoginModel
    {


        [Required(ErrorMessage = "Please Fill User Number...")]
        [StringLength(50, MinimumLength = 3)]
        public string username
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please Fill Password Number...")]
        [StringLength(50, MinimumLength = 3)]
        public string password
        {
            get;
            set;
        }


        public int Logincheck()
        {
            if(username.ToLower()=="admin" && password.ToLower()=="admin")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }



    }
}