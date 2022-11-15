using Backend.Domain.Entities.Base;
using FluentValidation.Results;

namespace Backend.Domain.Entities
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public void Validate(out ValidationResult validationResult)
        {
            validationResult = new ClientValidator().Validate(this);
        }
    }
}