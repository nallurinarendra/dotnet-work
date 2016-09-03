using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_MatheMaticalApplication.Models
{
    public class MatheMaticalModel
    {
        public int firstvalue
        {
            get;
            set;
        }
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