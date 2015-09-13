using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Util;
using System.Web.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;

namespace HW_CSharp_09_11._09.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public async Task<ActionResult> GetTodosAsync()
        {
            var uri = "http://jsonplaceholder.typicode.com/todos/";
            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(uri);
                Stream stream = await response.Content.ReadAsStreamAsync();
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Models.ToDo>));
                List<Models.ToDo> todoList = serializer.ReadObject(stream) as List<Models.ToDo>;
                Models.TodoListModel model = new Models.TodoListModel();
                model.todos = todoList;
                return View(model);
            }
        }
    }
}