using FluentValidation.Results;
using MediatR;
using Backend.Application.Queries.Validators;
using Backend.Application.Queries.ViewModel;

namespace Backend.Application.Queries
{
    public class GetClientByNameQuery : IRequest<ClientViewModel>
    {
        public string Name { get; set; }

        public void Validate(out ValidationResult validationResult)
        {
            validationResult = new GetClientByNameQueryValidator().Validate(this);
        }
    }
}