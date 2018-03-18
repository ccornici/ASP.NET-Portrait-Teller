using Microsoft.ProjectOxford.Face.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortraitTeller.Models
{
    public class ImageInfo
    {
        public string ImageUrl { get; set; }

        public Face[] FaceInfo { get; set; }
    }
}