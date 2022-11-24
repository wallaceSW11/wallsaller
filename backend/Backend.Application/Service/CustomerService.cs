using Backend.Domain.Interfaces;
using Backend.Application.Commands.Customer;
using Backend.Application.Mappings;
using Backend.Application.Queries.Customer;
using Backend.Application.Queries.ViewModel;
using Backend.Domain.Entities;
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

            if (_repository.Exists(command.Identity))
            {
                throw new ValidationDataException($"Customer already registered: {command.Identity}");
            }

            var entity = CustomerMapper.ToEntity(command);

            return _repository.Insert(entity);

        }

        public Task<bool> Update(UpdateCustomerCommand command)
        {
            command.Validate(out var validationResult);

            if (!validationResult.IsValid)
            {
                throw new ValidationDataException(validationResult.Errors);
            }

            if (!_repository.Exists(command.Id))
            {
                throw new NotFoundException($"Customer didn't found: {command.Id}");
            }

            return _repository.Update(CustomerMapper.ToEntity(command));
        }

        public bool Delete(DeleteCustomerCommand command)
        {
            command.Validate(out var validationResult);

            if (!validationResult.IsValid)
            {
                throw new ValidationDataException(validationResult.Errors);
            }

            var entity = _repository.GetById(int.Parse(command.Id)).Result;

            if (!_repository.Exists(command.Id))
            {
                throw new NotFoundException($"Customer didn't found: {command.Id}");
            }

            return _repository.Delete(int.Parse(command.Id));
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

        public Task<IEnumerable<Customer>> GetAll()
        {
            var customers = _repository.GetAll();

            return customers;
        }



    }
}