using ShaneMaravillo.SchoolFacilities.Web.Infrastructures.Data.Helpers;
using ShaneMaravillo.SchoolFacilities.Web.Infrastructures.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShaneMaravillo.SchoolFacilities.Web.Areas.Manage.ViewModels.Posts
{
    public class IndexViewModel
    {
        public Page<Post> Posts { get; set; }
    }
}
