using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace Author.moduls.models
{
    public class user
    {
        public string Name { get; set; } 
        public string address { get; set; }
        public string phone { get; set; }
        public string emial { get; set; }
        public DateTime createAt { get; set; }
        public  DateTime UpdatedAt{ get; set; } 

    }
}