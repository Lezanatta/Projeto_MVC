using ProjetoCurso.Models;
using ProjetoCurso.Models.Enums;
using System;
using System.Linq;

namespace ProjetoCurso.Data
{
    public class SeedingService
    {
        private ProjetoCursoContext _context;

        public SeedingService(ProjetoCursoContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() || 
                _context.Seller.Any() ||
                _context.SalesRecords.Any())
            {
                return; //DB ja foi populado
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1,"Bob Brow", "Bob!@gmail.com", new DateTime(1998,4,21), 1000, d1);
            Seller s2 = new Seller(2, "Maria Green", "Maria!@gmail.com", new DateTime(1979, 12, 31), 3500, d2);
            Seller s3 = new Seller(3, "Alex Grey", "Alex!@gmail.com", new DateTime(1988, 1, 15), 2200, d1);
            Seller s4 = new Seller(4, "Martha Fed", "Martha!@gmail.com", new DateTime(1993,11, 30), 3000, d4);
            Seller s5 = new Seller(5, "Donald Blue", "Donald!@gmail.com", new DateTime(2000, 1, 9), 4000, d3);
            Seller s6 = new Seller(6, "Alex Pink", "Alex!@gmail.com", new DateTime(1997, 3, 4), 3000, d2);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000, SalesStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2018, 09, 4), 7000, SalesStatus.Billed, s1);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2018, 09, 13), 8000, SalesStatus.Billed, s2);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2018, 09, 1), 4000, SalesStatus.Billed, s3);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2018, 09, 21), 5000, SalesStatus.Billed, s5);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(2018, 09, 15), 13000, SalesStatus.Billed, s6);
            SalesRecord sr7 = new SalesRecord(7, new DateTime(2018, 09, 28), 1000, SalesStatus.Billed, s2);
            SalesRecord sr8 = new SalesRecord(8, new DateTime(2018, 09, 11), 12000, SalesStatus.Billed, s4);
            SalesRecord sr9 = new SalesRecord(9, new DateTime(2018, 09, 14), 9000, SalesStatus.Billed, s4);
            SalesRecord sr10 = new SalesRecord(10, new DateTime(2018, 09, 7), 7000, SalesStatus.Billed, s4);
            SalesRecord sr11= new SalesRecord(11, new DateTime(2018, 09, 13), 6000, SalesStatus.Billed, s1);
            SalesRecord sr12 = new SalesRecord(12, new DateTime(2018, 09, 25), 2000, SalesStatus.Billed, s3);
            SalesRecord sr13 = new SalesRecord(13, new DateTime(2018, 09, 29), 1000, SalesStatus.Billed, s3);
            SalesRecord sr14 = new SalesRecord(14, new DateTime(2018, 09, 4), 15000, SalesStatus.Billed, s3);
            SalesRecord sr15 = new SalesRecord(15, new DateTime(2018, 09, 13), 11000, SalesStatus.Billed, s5);
            SalesRecord sr16 = new SalesRecord(16, new DateTime(2018, 09, 12), 14000, SalesStatus.Billed, s5);
            SalesRecord sr17 = new SalesRecord(17, new DateTime(2018, 09, 15), 10000, SalesStatus.Billed, s5);
            SalesRecord sr18 = new SalesRecord(18, new DateTime(2018, 09, 11), 9000, SalesStatus.Billed, s4);
            SalesRecord sr19 = new SalesRecord(19, new DateTime(2018, 09, 10), 8000, SalesStatus.Billed, s2);
            SalesRecord sr20 = new SalesRecord(20, new DateTime(2018, 09, 9), 7000, SalesStatus.Billed, s2);
            SalesRecord sr21 = new SalesRecord(21, new DateTime(2018, 09, 4), 3000, SalesStatus.Billed, s2);
            SalesRecord sr22 = new SalesRecord(22, new DateTime(2018, 09, 26), 10000, SalesStatus.Billed, s5);
            SalesRecord sr23 = new SalesRecord(23, new DateTime(2018, 09, 25), 15000, SalesStatus.Billed, s6);
            SalesRecord sr24 = new SalesRecord(24, new DateTime(2018, 09, 24), 16000, SalesStatus.Billed, s3);
            SalesRecord sr25 = new SalesRecord(25, new DateTime(2018, 09, 23), 22000, SalesStatus.Billed, s2);
            SalesRecord sr26 = new SalesRecord(26, new DateTime(2018, 09, 1), 13000, SalesStatus.Billed, s1);
            SalesRecord sr27 = new SalesRecord(27, new DateTime(2018, 09, 15), 15000, SalesStatus.Billed, s4);
            SalesRecord sr28 = new SalesRecord(28, new DateTime(2018, 09, 14), 14000, SalesStatus.Billed, s5);
            SalesRecord sr29 = new SalesRecord(29, new DateTime(2018, 09, 13), 4000, SalesStatus.Billed, s3);
            SalesRecord sr30 = new SalesRecord(30, new DateTime(2018, 09, 10), 3000, SalesStatus.Billed, s4);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecords.AddRange(
                sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr8,sr9, sr10, sr11, sr12
                ,sr13, sr14, sr15, sr16, sr17, sr18, sr19, sr20
                , sr21, sr22, sr23, sr24, sr25, sr26, sr27, sr28, sr29, sr30);

            _context.SaveChanges();
        }
    }
}
