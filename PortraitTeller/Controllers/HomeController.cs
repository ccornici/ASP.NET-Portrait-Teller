using Microsoft.ProjectOxford.Face.Contract;
using PortraitTeller.Models;
using PortraitTeller.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PortraitTeller.Controllers
{
    public class HomeController : AsyncController
    {
        private ICognitiveService _cognitiveService;

        public HomeController(ICognitiveService cognitiveService) => _cognitiveService = cognitiveService;

        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> ProcessImage(string imageUrl)
        {
            Face[] result = await _cognitiveService.ProcessPortraitAsync(imageUrl);
            ImageInfo imageInfo = new ImageInfo()
            {
                ImageUrl = imageUrl,
                FaceInfo = result
            };

            return View("PortraitResult", imageInfo);
        }
    }
}