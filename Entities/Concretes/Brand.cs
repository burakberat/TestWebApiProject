using Core.Entities;

namespace Entities.Concretes
{
    public class Brand : BaseEntity<int>
    {
        public string Name { get; set; }
    }
}
