using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Lesson01.Controllers
{
    public class ContentController : Controller
    {
        private readonly Content contents;

        public ContentController(IOptions<Content> option)
        {
            contents = option.Value;
        }


        public IActionResult Index()
        {
           
            return View(new Lesson01.Models.ContentViewModel() {  Contents=new List<Content>() { contents } });
        }
    }
}