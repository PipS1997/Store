using Store.Web.Data.Entities;

namespace Store.Web.Data
{
    public class Country : IEntity
    {
        public int Id { get; set; }


        public string Name { get; set; }

        
    }
}
