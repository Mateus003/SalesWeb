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

        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Departament() { }


        public Departament(int id, string name){
            Id = id;
            Name = name;
        }

        public void AddASeller(Seller seller)
        {
            Sellers.Add(seller);
        }


        public double TotalSales(DateTime initial, DateTime final) => Sellers.Sum(sl => sl.TotalSales(initial, final));



    }
}
