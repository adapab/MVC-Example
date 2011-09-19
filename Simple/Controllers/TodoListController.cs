using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Simple.Models;

namespace Simple.Controllers
{
    public class TodoListController : Controller
    {
        Database1Entities db = new Database1Entities();
       

        public ActionResult Index()
        {
            return View();
        }



         #region Json Methods Used for Insert todoList Element
        public JsonResult InsertTodoItem(String id)
        {
             
            try
            {
                Simple.Models.Datum oDatum = new Simple.Models.Datum();
                oDatum.Todo = id;
                oDatum.Sort =db.Data.Count()+1;
                db.Data.AddObject(oDatum);
                db.SaveChanges();

                return Json(true, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex) { }
            return null;
        }


#endregion
       

    }
}
