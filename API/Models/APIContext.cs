using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class APIContext: DbContext
    {
        public APIContext() { }
        public APIContext(DbContextOptions<APIContext> options) : base(options) { }
    }
}
