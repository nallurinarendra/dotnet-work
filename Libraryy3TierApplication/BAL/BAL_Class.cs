using Libraryy3TierApplication.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraryy3TierApplication.BAL
{
    class BAL_Class
    {
        public int rno
        {
            get;
            set;
        }

        public string bname
        {
            get;
            set;
        }

        public string aname
        {
            get;
            set;
        }

        DAL_Class obj = new DAL_Class();

        public void Bal_Insert_Book()
        {
            obj.Dal_Insert_Book(this);
        }

        public void Bal_Update_Book()
        {
            obj.Dal_Update_Book(this);
        }

        public void Bal_Delete_Book()
        {
            obj.Dal_Delete_Book(this);
        }

        public DataSet Bal_Select_Books()
        {
           
           return obj.Dal_Select_Books();
        }


    }
}
