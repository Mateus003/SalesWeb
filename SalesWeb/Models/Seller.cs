using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWeb.Models
{
    public class Seller
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public double BaseSalary { get; set; }

        public DateTime BirthDate { get; set; }

        public Departament Departament { get; set; }

        public ICollection<SellerRecords> SellerRecords { get; set; } = new List<SellerRecords>();

        public Seller() { }

        public Seller(int id, string name, double baseSalary, DateTime birthDate, Departament departament)
        {
            Id = id;
            Name = name;
            BaseSalary = baseSalary;
            BirthDate = birthDate;
            Departament = departament;

        }

        public void AddSales(SellerRecords sellerRecord)
        {
            SellerRecords.Add(sellerRecord);
        }


        public void RemoveSales(SellerRecords sellerRecord)
        {
            SellerRecords.Remove(sellerRecord);
        }

        public double TotalSales(DateTime initial, DateTime final) => SellerRecords.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr=> sr.Amount);
        


    }
}
