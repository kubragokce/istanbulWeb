using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace istanbulWeb.Identity
{
    public class ApplicationRole : IdentityRole
    {
        public string Description { get; set; }
    }
}