using ShaneMaravillo.SchoolFacilities.Web.Infrastructures.Data.Enums;
using ShaneMaravillo.SchoolFacilities.Web.Infrastructures.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShaneMaravillo.SchoolFacilities.Web.Infrastructures.Data.Models
{
    public class UserRole : BaseModel
    {
        public Guid? UserId { get; set; }

        public Role Role { get; set; }
    }
}
