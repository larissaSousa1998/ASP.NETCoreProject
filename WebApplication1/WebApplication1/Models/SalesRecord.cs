using System;
using WebApplication1.Models.Enums;

namespace WebApplication1.Models {
    public class SalesRecord {

        public int Id { get; set; }

        public DateTime Date { get; set; }
        public SalesStatus status { get; set; }

        public double Amount { get; set; }


        public Seller Seller { get; set; }

        public SalesRecord() {

        }

        public SalesRecord(int id, DateTime date, double amount, SalesStatus status, Seller seller) {
            Id = id;
            Date = date;
            Amount = amount;
            this.status = status;
            Seller = seller;
        }
    }
}
