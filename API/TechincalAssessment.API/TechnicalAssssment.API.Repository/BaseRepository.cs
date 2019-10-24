using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalAssssment.API.Repository
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
