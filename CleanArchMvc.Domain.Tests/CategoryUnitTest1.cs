using CleanArchMvc.Domain.Entities;
using FluentAssertions;

namespace CleanArchMvc.Domain.Tests
{
    public class CategoryUnitTest1
    {
        /// <summary>
        /// N�o deve lan�ar uma excess�o no dom�nio se estiver errado a categoria.
        /// </summary>
        [Fact]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Category Name");
            action.Should()
                .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        /// <summary>
        /// Ser� lan�ado uma excess�o pelo Id ser inv�lido.
        /// </summary>
        [Fact]
        public void CreateCategory_NegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Category(-1, "Category Name");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id Value");
        }
    }
}