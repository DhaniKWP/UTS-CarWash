using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CarWash.Data;
using CarWash.Models;

namespace CarWash.Services
{
    public class TransactionService
    {
        private readonly AppDbContext _context;

        public TransactionService()
        {
            _context = new AppDbContext();
        }

        //public List<Transaction> GetAllTransactions()
        //{
        //    return _context.Transactions
        //        .Include(t => t.Client)
        //        .Include(t => t.Package)
        //        .ToList();
        //}

        //public Transaction GetTransactionById(int id)
        //{
        //    return _context.Transactions
        //        .Include(t => t.Client)
        //        .Include(t => t.Package)
        //        .FirstOrDefault(t => t.TransactionId == id);
        //}

        public void AddTransaction(Transaction transaction)
        {
            // Hitung total harga otomatis dari package
            var package = _context.Packages.FirstOrDefault(p => p.Id == transaction.PackageId);
            if (package != null)
                transaction.Price = package.Price;

            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }

        public void UpdateTransaction(Transaction transaction)
        {
            _context.Transactions.Update(transaction);
            _context.SaveChanges();
        }

        public void DeleteTransaction(int id)
        {
            var trans = _context.Transactions.FirstOrDefault(t => t.Id == id);
            if (trans != null)
            {
                _context.Transactions.Remove(trans);
                _context.SaveChanges();
            }
        }
    }
}
