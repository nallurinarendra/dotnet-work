using ProductStoreProcedureExample.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStoreProcedureExample.BAL
{
    class BAL_Class
    {
        public int p_pno
        {
            get;
            set;
        }
        public string p_pname
        {
            get;
            set;
        }

        public double p_rate
        {
            get;
            set;
        }
        DAL_Class obj = new DAL_Class();
        public void BAL_Insert()
        {
            obj.DAL_Insert(this);
        }

        public void BAL_Update()
        {
            obj.DAL_Update(this);
        }

        public void BAL_Delete()
        {
            obj.DAL_Delete(this);
        }


        public DataSet BAL_Display()
        {
            return obj.DAL_Display();
        }
        public void BAL_Find()
        {
            obj.DAL_Find(this);
        }
    }

}
