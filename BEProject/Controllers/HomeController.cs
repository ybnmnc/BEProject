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
        private BaseMainContext context;

        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(TodoList list)
        {
            var memoryOptions = new DbContextOptionsBuilder<BaseMainContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            string Name = list.Name;
            DateTime date = list.CreateDate;
            int status = list.Status;


            return View();
        }


        [HttpPost]
        public ActionResult Addİtem(FormCollection fc)
        {

            var item = new TodoList();

            item.Name = fc["Name"].ToString();
            item.CreateDate = DateTime.Now;
            item.Status = 1;

            context.TodoListSet.Add(item);
            context.SaveChanges();


            ViewBag.Message = "item add in todoList";

            return View(); 
        }

        [HttpGet]
        public ActionResult GetTodoList()
        {
            var result=context.TodoListSet.ToList();

            return View();
        }
    }
}