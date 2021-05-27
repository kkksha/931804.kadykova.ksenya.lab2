using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CalcServiceController : Controller
    {
        public IActionResult Index(){return View();}

        public IActionResult Manual(int first, int second, char operation){
            if (Request.Method == "GET") {
                ViewData["Title"] = "Manual With Separate Handlers";
                return View("All");}
            else{
                Class value = new Class();
                value.first = first;
                value.second = second;
                ViewBag.first = value.first;
                ViewBag.second = value.second;
                switch (operation){
                    case '+': ViewBag.res = value.Add(); ViewBag.op = '+'; break;
                    case '-': ViewBag.res = value.Sub(); ViewBag.op = '-'; break;
                    case '*': ViewBag.res = value.Mult(); ViewBag.op = '*'; break;
                    case '/': ViewBag.res = value.Div(); ViewBag.op = '/'; break; }
                ViewData["Title"] = "Result:";
                return View("FirstRes");}
        }

        [HttpGet]
        public IActionResult ManualWithSeparateHandlers(){
            ViewData["Title"] = "Manual With Separate Handlers";
            return View("All"); }

        [HttpPost]
        public IActionResult ManualWithSeparateHandlers(int first, int second, char operation){
            Class value = new Class();
            value.first = first;
            value.second = second;
            ViewBag.first = value.first;
            ViewBag.second = value.second;
            switch (operation){
                case '+': ViewBag.res = value.Add(); ViewBag.op = '+'; break;
                case '-': ViewBag.res = value.Sub(); ViewBag.op = '-'; break;
                case '*': ViewBag.res = value.Mult(); ViewBag.op = '*'; break;
                case '/': ViewBag.res = value.Div(); ViewBag.op = '/'; break;}
            ViewData["Title"] = "Result:";
            return View("FirstRes");
        }

        [HttpGet]
        public IActionResult ModelBindingInParametrs(){
            ViewData["Title"] = "Model Binding In Parametrs";
            return View("All");}

        [HttpPost]
        public IActionResult ModelBindingInParametrs([Bind("first,second")]Class value,char operation){ 
            switch (operation){
                case '+': ViewBag.res = value.Add(); break;
                case '-': ViewBag.res = value.Sub(); break;
                case '*': ViewBag.res = value.Mult(); break;
                case '/': ViewBag.res = value.Div(); break;}

            ViewData["Title"] = "Result:";
            return View("SecRes"); }

        [HttpGet]
        public IActionResult ModelBindingInSeparateModel(){
            ViewData["Title"] = "Model Binding In Parametrs";
            return View("All"); }

        [HttpPost]
        public IActionResult ModelBindingInSeparateModel(Class value, char operation){
            switch (operation){
                case '+': ViewBag.res = value.Add(); break;
                case '-': ViewBag.res = value.Sub(); break;
                case '*': ViewBag.res = value.Mult(); break;
                case '/': ViewBag.res = value.Div(); break;}
            ViewData["Title"] = "Result:";
            return View("SecRes");
        }
    }
}