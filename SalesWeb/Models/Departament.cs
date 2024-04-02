﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWeb.Models
{
    public class Departament
    {
        public int Id { get; set; }


        public string Name { get; set; }

        public Departament()
        {

        }
        public Departament(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
