using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_MatheMaticalApplication.Models
{
    public class MatheMaticalModel
    {
        [Required(ErrorMessage="Please Fill First Number...")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Please enter numbers only.")]
        [Range(1,99,ErrorMessage="Please Enter Number in between the 1 to 99 values...")]
       // [StringLength(2, ErrorMessage = "Last Name length Should be less than 3 Digits")]   this is used for strings range     
        public int firstvalue
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please Fill Second Number...")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Please enter numbers only.")]
        [Range(1, 10, ErrorMessage = "Please Enter Number in between the 1 to 10 values...")]
     
        public int Sedondvalue
        {
            get;
            set;
        }

        public int Addition()
        {
            return firstvalue + Sedondvalue;
        }

        public int substraction()
        {
            return firstvalue - Sedondvalue;
        }

        public int Multiplication()
        {
            return firstvalue * Sedondvalue;
        }

        public int Division()
        {
            return firstvalue - Sedondvalue;
        }

        public int Remainder()
        {
            return firstvalue / Sedondvalue;
        }
    }
}