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

    private Task<bool> InsertCustomer()
    {
        var command = new InsertCustomerCommand()
        {
            Name = "wallzin",
            Identity = "111222333444",
            Email = "wall@wall.com.br",
            BirthDate = Convert.ToDateTime("2000-11-18"),
            PhoneNumber = "22223333"
        };

        return _service.Insert(command);
    }


    [Fact]
    public void Should_Insert_Customer()
    {
        Assert.True(InsertCustomer().Result);
    }

    [Fact]
    public void Should_Throw_Exception_To_Insert_Customer()
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
}