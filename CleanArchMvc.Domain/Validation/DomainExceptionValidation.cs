namespace CleanArchMvc.Domain.Validation
{
    public class DomainExceptionValidation : Exception
    {
        public DomainExceptionValidation(string error) : base(error)
        {
        }

        /// <summary>
        /// Método para validar erro.
        /// </summary>
        /// <param name="hasError"></param>
        /// <param name="error"></param>
        /// <exception cref="DomainExceptionValidation"></exception>
        public static void When(bool hasError, string error) 
        {
            if (hasError) 
            {
                throw new DomainExceptionValidation(error);
            }
        }
    }
}
