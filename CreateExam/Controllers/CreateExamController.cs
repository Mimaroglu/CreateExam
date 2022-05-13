using CreateExam.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using System.Xml;

namespace CreateExam.Controllers
{
    public class CreateExamController : Controller
    {
        // GET: CreateExamController
        public IActionResult Index()
        {
            var model = ReadRssOfWired();
            return View(model);
        }

        public static Wired ReadRssOfWired()
        {
            Wired models = new Wired();
            models.NewsList = new List<News>();
            var url = "https://www.wired.com/feed/rss";
            using var reader = XmlReader.Create(url);
            var feed = SyndicationFeed.Load(reader);
            foreach (var item in feed.Items.Take(5))
            {
                models.NewsList.Add(new News { Id = item.Id, Title = item.Title.Text, Description = item.Summary.Text });
            }
            return models;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromBody] RequestModel.Request data)
        {
            //Burada formu alıp kayıt işlemi yapacaktık.
            return Ok();
        }

       
    }

    
}
