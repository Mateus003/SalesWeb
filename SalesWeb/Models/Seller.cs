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

        public ICollection<SalesRecord> SellerRecords { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(int id, string name, string email,  DateTime birthDate, double baseSalary, Departament departament)
        {
           
            Id = id;
            Name = name;
            Email = email;
            BaseSalary = baseSalary;
            BirthDate = birthDate;
            Departament = departament;

        }

     

        public void AddSales(SalesRecord salesRecord)
        {
            SellerRecords.Add(salesRecord);
        }


        public void RemoveSales(SalesRecord salesRecord)
        {
            SellerRecords.Remove(salesRecord);
        }

        public double TotalSales(DateTime initial, DateTime final) => SellerRecords.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr=> sr.Amount);
        


    }
}
