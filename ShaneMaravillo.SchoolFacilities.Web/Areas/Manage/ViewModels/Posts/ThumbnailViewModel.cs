using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShaneMaravillo.SchoolFacilities.Web.Areas.Manage.ViewModels.Posts
{
    public class ThumbnailViewModel
    {
        public Guid? PostId { get; set; }
        public IFormFile Thumbnail { get; set; }
    }
}
