using FluentValidation.Results;
using MediatR;
using Backend.Application.Commands.Validators;
using Backend.Application.Queries.ViewModel;

namespace Backend.Application.Commands
{
    public class InsertClientCommand : IRequest<ClientViewModel>
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public void Validate(out ValidationResult validationResult)
        {
            validationResult = new InsertClientCommandValidator().Validate(this);
        }
    }
}