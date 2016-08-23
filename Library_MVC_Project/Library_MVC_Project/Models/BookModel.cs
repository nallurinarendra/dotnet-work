using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library_MVC_Project.Models
{
    public class BookModel
    {

        [Required(ErrorMessage = "Please Fill Book ID...")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Please enter numbers only.")]  
       
        public int BookID
        {
            get;
            set;
        }


        [Required(ErrorMessage = "Please Fill First Number...")]
        [DataType(DataType.Text)]       
        public string BookName
        {
            get;
            set;
        }


        [Required(ErrorMessage = "Please Fill First Number...")]
        [DataType(DataType.Text)]     
        public string AuthorName
        {
            get;
            set;
        }


        [Required(ErrorMessage = "Please Fill First Number...")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Please enter numbers only.")]
        [Range(1, 300, ErrorMessage = "Please Enter Number in between the 1 to 300 values...")]
       
        public int RackNo
        {
            get;
            set;
        }

        public void insertbook()
        {
            using (LibraryDBEntities ldb = new LibraryDBEntities())
            {
                BookTable bt = new BookTable()
                {
                   Id=BookID,
                   BookName=BookName,
                   AuthorName=AuthorName,
                   RackNumber=RackNo
                };

                ldb.BookTables.Add(bt);
                ldb.SaveChanges();
            }
        }


        public void updatebook()
        {
            using (LibraryDBEntities ldb = new LibraryDBEntities())
            {
                BookTable str = (from st in ldb.BookTables

                                 where st.Id == BookID

                                 select st).First();

                  str.BookName=BookName;
                   str.AuthorName=AuthorName;
                   str.RackNumber = RackNo;

                   ldb.SaveChanges();
            }
        }

        public void deletebook()
        {
            using (LibraryDBEntities ldb = new LibraryDBEntities())
            {
                BookTable str = (from st in ldb.BookTables

                                 where st.Id == BookID

                                 select st).First();

                ldb.BookTables.Remove(str);
                ldb.SaveChanges();
            }
        }
    }
}