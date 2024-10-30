using System;
using Newtonsoft.Json;
using RentCarClient.Models.Input;
using RentCarClient.Models.Output;
using RentCarClient.Service;

namespace RentCarClient.Handlers;

public class CustomerHandler : ICustomer
{
    private readonly IConfiguration _configuration;
    private readonly string baseUrl = "";
    private HttpClient httpClient = new HttpClient();

    public CustomerHandler(IConfiguration configuration)
    {
        _configuration = configuration;
        baseUrl = _configuration["apiEndpoint"];
    }

    public async Task<ApiResponse<string>> LoginCustomer(LoginCustomerInput request)
    {
        if (request == null)
        {
            return new ApiResponse<string>
            {
                StatusCode = 400,
                Data = "Bad Request"
            };
        }

        string endpoint = baseUrl + "Customer/Login";
        var response = await httpClient.PostAsJsonAsync(endpoint, request);
        var apiResponse = await response.Content.ReadFromJsonAsync<ApiResponse<string>>();

        return apiResponse;
    }

    public async Task<ApiResponse<string>> CreateCustomer(CreateCustomerInput request)
    {
        if (request == null)
        {
            return new ApiResponse<string>
            {
                StatusCode = 400,
                Data = "Bad Request"
            };
        }

        string endpoint = baseUrl + "Customer/Register";
        var response = await httpClient.PostAsJsonAsync(endpoint, request);
        var apiResponse = await response.Content.ReadFromJsonAsync<ApiResponse<string>>();

        return apiResponse;
    }
}
