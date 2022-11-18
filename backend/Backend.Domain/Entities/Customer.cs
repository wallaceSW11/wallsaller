using Backend.Domain.Entities.Base;
using FluentValidation.Results;

namespace Backend.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Identity { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }

        public void Validate(out ValidationResult validationResult)
        {
            validationResult = new CustomerValidator().Validate(this);
        }
    }
}