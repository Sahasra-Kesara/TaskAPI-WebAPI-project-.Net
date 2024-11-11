using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.DataAccess;

namespace TaskAPI.Services.Authors
{
    
    public class AuthorSqlServerService : IAuthorRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();
        public List<author> GetAllAuthors()
        {
            return _context.Authors.ToList();
        }

        public List<author> GetAuthors(string job)
        {
            if (string.IsNullOrWhiteSpace(job))
            {
                return GetAllAuthors();
            }
            job = job.Trim();

            return _context.Authors.Where(a => a.JobRole == job).ToList();
        }

        public author GetAuthor(int id)
        {
            return _context.Authors.Find(id);
        }
    }
}
