using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SocioCode.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the SocioCodeUser class
    public class SocioCodeUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="nvarchar(100)")]
        public string FristName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string EmailID { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Password { get; set; }


    }
}
