using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Web.Data
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository    
    {
        public CountryRepository(DataContext context) : base(context)
        {

        }
    }
}
