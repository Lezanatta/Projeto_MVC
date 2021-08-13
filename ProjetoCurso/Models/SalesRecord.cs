﻿using ProjetoCurso.Models.Enums;
using System;

namespace ProjetoCurso.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Double Amount { get; set; }
        public SalesStatus Status { get; set; }
        public Seller Seller  { get; set; }

        public SalesRecord()
        {

        }
        public SalesRecord(int id, DateTime date, double amount, SalesStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}