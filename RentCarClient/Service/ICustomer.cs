using System;
using Microsoft.AspNetCore.Mvc;
using RentCarClient.Models.Input;
using RentCarClient.Models.Output;

namespace RentCarClient.Service;

public interface ICustomer
{
    Task<ApiResponse<string>> LoginCustomer(LoginCustomerInput request);
    Task<ApiResponse<string>> CreateCustomer(CreateCustomerInput request);
}
