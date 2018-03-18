using Microsoft.ProjectOxford.Face;
using Microsoft.ProjectOxford.Face.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;

namespace PortraitTeller.Services
{
    public class CognitiveService : ICognitiveService
    {
        private readonly IFaceServiceClient _client;

        public CognitiveService()
        {
            var url = WebConfigurationManager.AppSettings["CognitiveServiciesUrl"];
            var key = WebConfigurationManager.AppSettings["CognitiveServicesFaceApiKey"];

            _client = new FaceServiceClient(key, url);
        }

        public async Task<Face[]> ProcessPortraitAsync(string imageUri)
        {
            var attributes = new FaceAttributeType[]
            {
                FaceAttributeType.Gender,
                FaceAttributeType.Age,
                FaceAttributeType.Smile,
                FaceAttributeType.Emotion
            };

            return await _client.DetectAsync
                (
                    imageUri,
                    returnFaceAttributes: attributes
                );
        }
    }
}