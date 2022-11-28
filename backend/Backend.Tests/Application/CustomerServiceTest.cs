using Xunit;
using Backend.Application.Commands.Customer;
using Backend.Application.Queries.Customer;
using Backend.Application.Service;
using Backend.Domain.Entities;
using Backend.Infra.Exceptions;
using Backend.Infra.Repositories;
using System;
using System.Threading.Tasks;

namespace Backend.Tests;

public class CustomerServiceTest
{
    private readonly CustomerService _service;

    private readonly CustomerRepository _repository;

    public CustomerServiceTest()
    {
        _repository = new CustomerRepository();
        _service = new CustomerService(_repository);
    }

    private Task<Customer> InsertCustomer(string? identity = "111222333444")
    {
        var command = new InsertCustomerCommand()
        {
            Name = "wallzin",
            Identity = identity,
            Email = "wall@wall.com.br",
            BirthDate = Convert.ToDateTime("2000-11-18"),
            PhoneNumber = "22223333"
        };

        return _service.Insert(command);
    }


    [Fact]
    public void Should_Insert_Customer()
    {
        Assert.IsType<Customer>(InsertCustomer().Result);
    }

    [Fact]
    public void Should_Throw_Exception_To_Insert_Customer_Without_Fields()
    {
        var command = new InsertCustomerCommand()
        {
            BirthDate = Convert.ToDateTime("2000-11-18"),
            PhoneNumber = "22223333"
        };

        var exception = Assert.ThrowsAsync<ValidationDataException>(() => _service.Insert(command)).Result;

        Assert.Contains("The name is required", exception.Message);
        Assert.Contains("The identity is required", exception.Message);
        Assert.Contains("The email is required", exception.Message);

    }

    [Fact]
    public void Should_Throw_Exception_When_Insert_The_Same_Customer()
    {
        InsertCustomer();

        var exception = Assert.ThrowsAsync<ValidationDataException>(() => InsertCustomer()).Result;

        Assert.Contains("Customer already registered", exception.Message);
    }

    [Fact]
    public void Should_Get_Customer_By_Id()
    {
        var customer = InsertCustomer().Result;

        var query = new GetCustomerByIdQuery() { Id = customer.Id.ToString() };

        var customerFound = _service.GetById(query).Result;

        Assert.NotNull(customerFound);
        Assert.Equal(customer.Id, customerFound.Id);
    }

    [Fact]
    public void Should_Get_Customer_By_Name()
    {
        var customer = InsertCustomer().Result;

        var query = new GetCustomerByNameQuery() { Name = customer.Name };

        var customerFound = _service.GetByName(query).Result;

        Assert.NotNull(customerFound);
        Assert.Equal(customer.Name, customerFound.Name);
    }

    [Fact]
    public void Should_Throw_Exception_Get_Customer_By_Id_Not_Found()
    {
        var query = new GetCustomerByIdQuery() { Id = "999" };

        var customerFound = _service.GetById(query).Result;

        Assert.Null(customerFound);
    }

    [Fact]
    public void Should_Throw_Exception_Get_Customer_By_Name_Not_Found()
    {
        var query = new GetCustomerByNameQuery() { Name = "wa" };

        var customerFound = _service.GetByName(query).Result;

        Assert.Null(customerFound);
    }

    [Fact]
    public void Should_Get_All_Customers()
    {
        InsertCustomer("111111111");
        InsertCustomer("222222222");
        InsertCustomer("333333333");

        var customers = _service.GetAll().Result;

        Assert.NotNull(customers);
    }

    [Fact]
    public void Should_Update_Customer()
    {
        var newName = "Customer updated";
        var customer = InsertCustomer().Result;

        var command = new UpdateCustomerCommand()
        {
            Id = customer.Id,
            Name = newName,
            Identity = customer.Identity,
            Email = customer.Email
        };

        _service.Update(command);

        var query = new GetCustomerByIdQuery() { Id = customer.Id.ToString() };

        var customerFound = _service.GetById(query).Result;

        Assert.Equal(newName, customerFound.Name);

    }

    [Fact]
    public void Should_Throw_Exception_Update_Customer_Without_Fields()
    {
        var customer = InsertCustomer();

        var command = new UpdateCustomerCommand()
        {
            Id = customer.Id,
            BirthDate = Convert.ToDateTime("2000-11-18"),
            PhoneNumber = "22223333"
        };

        var exception = Assert.ThrowsAsync<ValidationDataException>(() => _service.Update(command)).Result;

        Assert.Contains("The name is required", exception.Message);
        Assert.Contains("The identity is required", exception.Message);
        Assert.Contains("The email is required", exception.Message);
    }

    [Fact]
    public void Should_Throw_Exception_Update_Customer_Not_Found()
    {

        var command = new UpdateCustomerCommand()
        {
            Id = 9999,
            Name = "wall",
            Identity = "1212121211",
            Email = "wall@wall.com",
            BirthDate = Convert.ToDateTime("2000-11-18"),
            PhoneNumber = "22223333"
        };

        var exception = Assert.ThrowsAsync<NotFoundException>(() => _service.Update(command)).Result;

        Assert.Contains("did not found", exception.Message);
    }

    [Fact]
    public void Should_Delete_Customer()
    {
        var customer = InsertCustomer("11222111222").Result;

        var command = new DeleteCustomerCommand() { Id = customer.Id.ToString() };

        Assert.True(_service.Delete(command));
    }
}