using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindDataContext db = new NorthwindDataContext();

            //#region Insert
            //Employee e = new Employee();
            //e.FirstName = "Berkay";
            //e.LastName = "Erken";
            //e.City = "İstanbul";
            //e.Address = "Eyüp";
            //e.HomePhone = "5151513354";

            //db.Employees.InsertOnSubmit(e);
            //db.SubmitChanges();
            //#endregion

            //#region Update
            //Employee e = db.Employees.FirstOrDefault(I => I.FirstName == "Berkay");
            //e.LastName = "asdqwdqd";
            //db.SubmitChanges();
            //#endregion


            //#region Delete
            //Employee e = db.Employees.FirstOrDefault(I => I.FirstName == "Berkay");
            //db.Employees.DeleteOnSubmit(e);
            //db.SubmitChanges();
            //#endregion



           

        }
    }
}
