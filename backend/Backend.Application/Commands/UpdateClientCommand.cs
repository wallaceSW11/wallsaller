using FluentValidation.Results;
using MediatR;
using Backend.Application.Commands.Validators;

namespace Backend.Application.Commands
{
    public class UpdateClientCommand : IRequest<bool>
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public void Validate(out ValidationResult validationResult)
        {
            validationResult = new UpdateClientCommandValidator().Validate(this);
        }
    }
}