using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Author.moduls.Data
{
    public class APiDbcontext:DbContext
    {
        public APiDbcontext(DbContextOptions<APiDbcontext>options)
        :base(options)
        {
            
        }
    }
}