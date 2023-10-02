using CleanArchMvc.Domain.Validation;

namespace CleanArchMvc.Domain.Entities
{

    public sealed class Category : Entity
    {
        public Category(string name)
        {
            ValidationDomain(name);
        }

        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value");
            Id = id;
            ValidationDomain(name);
        }

        public string Name { get; protected set; }

        public List<Product> Products { get; set;}


        public void Update(string name)
        {
            ValidationDomain(name);
        }

        private void ValidationDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "Invalid name. Name is required");

            DomainExceptionValidation.When(name.Length < 3,
                "Invalid name, too short, minimum 3 charecters");

            Name = name;
        }
    }
}
