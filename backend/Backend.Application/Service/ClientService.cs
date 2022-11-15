using Backend.Domain.Interfaces;
using Backend.Application.Commands;
using Backend.Application.Mappings;
using Backend.Application.Queries;
using Backend.Application.Queries.ViewModel;

// using Backend.Domain.Entities; // rever para remover essa dependencia.


namespace Backend.Application.Service
{
    public class ClientService
    {
        private readonly IClientRepository _repository;

        public ClientService(IClientRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Insert(InsertClientCommand command)
        {
            command.Validate(out var validationResult);

            if (!validationResult.IsValid)
            {
                throw new Exception(validationResult.Errors.ToString());
            }

            var entity = ClientMapper.ToEntity(command);

            return await _repository.Insert(entity);
        }

        public async Task<ClientViewModel> GetByName(GetClientByNameQuery query)
        {
            query.Validate(out var validationResult);

            if (!validationResult.IsValid)
            {
                throw new Exception(validationResult.Errors.ToString());
            }

            var client = await _repository.GetByName(query.Name);

            return ClientMapper.ToResponse(client);
        }



    }
}