using FluentValidation.Results;
using MediatR;
using Backend.Application.Queries.Customer.Validators;
using Backend.Application.Queries.ViewModel;
using Backend.Domain.Entities;

namespace Backend.Application.Queries.Customer
{
    public class GetCustomers : IRequest<IEnumerable<Backend.Domain.Entities.Customer>>
    {

    }
}