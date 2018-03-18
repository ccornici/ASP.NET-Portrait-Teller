using Microsoft.ProjectOxford.Face.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortraitTeller.Services
{
    public interface ICognitiveService
    {
        Task<Face[]> ProcessPortraitAsync(string imageUrl);
    }
}
