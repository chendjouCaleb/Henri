using System.Collections.Generic;
using Henri.Core.Controllers;
using Henri.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Henri.WebApi.Controllers
{
    
    [Route("api/images")]
    public class ImageController
    {
        
        [HttpGet]
        public IList<Image> List()
        {
            ImageService service = new ImageService();

            return service.List();
        }

        [HttpGet("{id}")]
        public ImageInfo Get(string id)
        {
            ImageService service = new ImageService();
            return service.GetImage(id);
        }
    }
}