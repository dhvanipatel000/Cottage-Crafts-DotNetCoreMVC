using cottage_crafts.Models;
using System.Collections.Generic;
using System.Linq;

namespace cottage_crafts.data.Services
{
    public class CraftRepository : ICraftRepository
    {
        AppDbContext context = null;


        public CraftRepository(AppDbContext _context)
        {
            context = _context;

        }

        IEnumerable<Crafts> ICraftRepository.GetAllCrafts()
        {
            IEnumerable<Crafts> temp = (context != null) ? context.Crafts : null;

            return (context.Crafts.Select(s => s).ToList());
        }

        Crafts ICraftRepository.GetCrafts(int id)
        {
            return context.Crafts.FirstOrDefault(m => m.cid == id);
        }
    }
}
