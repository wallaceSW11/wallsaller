using Backend.Application.Commands;
using Backend.Application.Queries.ViewModel;
using Backend.Domain.Entities;

namespace Backend.Application.Mappings
{
    public class ClientMapper
    {
        public static Client ToEntity(InsertClientCommand command) => new() { Name = command.Name, PhoneNumber = command.PhoneNumber };

        public static ClientViewModel ToResponse(Client entity) => entity == null ? null : new() { Name = entity.Name, PhoneNumber = entity.PhoneNumber };


    }
}