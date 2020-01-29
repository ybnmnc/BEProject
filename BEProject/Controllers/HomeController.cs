using BEProject.Data;
using BEProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BEProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Addİtem(FormCollection fc)
        {
            var memoryOptions = new DbContextOptionsBuilder<BaseMainContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            using (var context= new BaseMainContext(memoryOptions))
            {
                var item =  new TodoList();

                //item.Name = fc["Name"].ToString();
                item.CreateDate = DateTime.Now;
                item.Status = 1;

                context.TodoListSet.Add(item);
            }

                ViewBag.Message = "item add in todoList";

            return View();
        }
    }
}