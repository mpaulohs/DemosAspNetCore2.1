using demo11serve.api.Data;
using demo11serve.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo11serve.api.Service
{
    public interface IServiceBook
    {
        IEnumerable<Book> GetAll();
    }

    public class ServiceBook : IServiceBook
    {
        private readonly ServeDbContext _context;
        
        public ServiceBook(ServeDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.Book;
        }
    }
}
