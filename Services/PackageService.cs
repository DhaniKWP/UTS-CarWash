using System.Collections.Generic;
using System.Linq;
using CarWash.Data;
using CarWash.Models;

namespace CarWash.Services
{
    public class PackageService
    {
        private readonly AppDbContext _context;

        public PackageService()
        {
            _context = new AppDbContext();
        }

        public List<Package> GetAllPackages()
        {
            return _context.Packages.ToList();
        }

        public Package GetPackageById(int id)
        {
            return _context.Packages.FirstOrDefault(p => p.PackageId == id);
        }

        public void AddPackage(Package package)
        {
            _context.Packages.Add(package);
            _context.SaveChanges();
        }

        public void UpdatePackage(Package package)
        {
            _context.Packages.Update(package);
            _context.SaveChanges();
        }

        public void DeletePackage(int id)
        {
            var package = _context.Packages.FirstOrDefault(p => p.PackageId == id);
            if (package != null)
            {
                _context.Packages.Remove(package);
                _context.SaveChanges();
            }
        }
    }
}
