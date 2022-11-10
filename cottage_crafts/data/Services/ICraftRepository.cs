using cottage_crafts.Models;
using System.Collections.Generic;

namespace cottage_crafts.data.Services
{
    public interface ICraftRepository
    {
        public Crafts GetCrafts(int Id);
        public IEnumerable<Crafts> GetAllCrafts();
    }
}
