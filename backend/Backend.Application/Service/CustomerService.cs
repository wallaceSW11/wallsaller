using Backend.Domain.Interfaces;
using Backend.Application.Commands.Customer;
using Backend.Application.Mappings;
using Backend.Application.Queries.Customer;
using Backend.Application.Queries.ViewModel;
using Backend.Infra.Exceptions;

namespace Backend.Application.Service
{
    public class CustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public Task<bool> Insert(InsertCustomerCommand command)
        {
            command.Validate(out var validationResult);

            if (!validationResult.IsValid)
            {
                throw new ValidationDataException(validationResult.Errors);
            }

            var entity = CustomerMapper.ToEntity(command);

            return _repository.Insert(entity);

        }

        public bool Update(UpdateCustomerCommand command)
        {
            command.Validate(out var validationResult);

            if (!validationResult.IsValid)
            {
                throw new ValidationDataException(validationResult.Errors);
            }

            var entity = _repository.GetById(command.Id).Result;

            if (entity == null)
            {
                throw new ValidationDataException($"Customer didn't found: {command.Id}");
            }

            entity.Name = command.Name;
            entity.PhoneNumber = command.PhoneNumber;

            return _repository.Update(entity);
        }

        public bool Delete(DeleteCustomerCommand command)
        {
            command.Validate(out var validationResult);

            if (!validationResult.IsValid)
            {
                throw new ValidationDataException(validationResult.Errors);
            }

            return _repository.Delete(command.Id);
        }


        public async Task<CustomerViewModel> GetByName(GetCustomerByNameQuery query)
        {
            query.Validate(out var validationResult);

            if (!validationResult.IsValid)
            {
                throw new ValidationDataException(validationResult.Errors);
            }

            var Customer = await _repository.GetByName(query.Name);

            return CustomerMapper.ToResponse(Customer);
        }

        public async Task<CustomerViewModel> GetById(GetCustomerByIdQuery query)
        {
            query.Validate(out var validationResult);

            if (!validationResult.IsValid)
            {
                throw new ValidationDataException(validationResult.Errors);
            }

            var Customer = await _repository.GetById(int.Parse(query.Id));

            return CustomerMapper.ToResponse(Customer);
        }



    }
}