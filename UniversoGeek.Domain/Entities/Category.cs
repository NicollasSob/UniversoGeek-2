using UniversoGeek.Core.DomainObjects;

namespace UniversoGeek.Domain.Entities
{
    public class Category : Entity
    {
        public Category(string name, string description, bool active)
        {
            Name = name;
            Description = description;
            Active = active;
        }

        protected Category() { }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool Active { get; private set; }
    }
}
