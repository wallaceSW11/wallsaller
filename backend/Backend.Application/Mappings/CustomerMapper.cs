using Backend.Application.Commands.Customer;
using Backend.Application.Queries.ViewModel;
using Backend.Domain.Entities;

namespace Backend.Application.Mappings
{
    public class CustomerMapper
    {
        public static Customer ToEntity(InsertCustomerCommand command) => new()
        {
            Name = command.Name,
            Identity = command.Identity,
            Email = command.Email,
            BirthDate = command.BirthDate,
            PhoneNumber = command.PhoneNumber
        };

        public static CustomerViewModel ToResponse(Customer entity) => entity == null ? null : new()
        {
            Id = entity.Id,
            Name = entity.Name,
            Identity = entity.Identity,
            Email = entity.Email,
            PhoneNumber = entity.PhoneNumber
        };


    }
}