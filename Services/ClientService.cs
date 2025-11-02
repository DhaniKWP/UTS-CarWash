using System.Collections.Generic;
using System.Linq;
using CarWash.Data;
using CarWash.Models;

namespace CarWash.Services
{
    public class ClientService
    {
        private readonly AppDbContext _context;

        public ClientService()
        {
            _context = new AppDbContext();
        }

        public List<Client> GetAllClients()
        {
            return _context.Clients.ToList();
        }

        public Client GetClientById(int id)
        {
            return _context.Clients.FirstOrDefault(c => c.Id == id);
        }

        public void AddClient(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        public void UpdateClient(Client client)
        {
            _context.Clients.Update(client);
            _context.SaveChanges();
        }

        public void DeleteClient(int id)
        {
            var client = _context.Clients.FirstOrDefault(c => c.Id == id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                _context.SaveChanges();
            }
        }
    }
}
