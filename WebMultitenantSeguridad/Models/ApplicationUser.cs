//using Finbuckle.MultiTenant;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMultitenantSeguridad.Models
{


    public class ApplicationUser : IdentityUser//MultiTenantIdentityUser
    {

        public string TenantId { get; set; }
    }


}
