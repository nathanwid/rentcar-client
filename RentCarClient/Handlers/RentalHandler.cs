using System;
using RentCarClient.Models.Input;
using RentCarClient.Models.Output;
using RentCarClient.Service;

namespace RentCarClient.Handlers;

public class RentalHandler : IRental
{
    private readonly IConfiguration _configuration;
    private readonly string baseUrl = "";
    private HttpClient httpClient = new HttpClient();

    public RentalHandler(IConfiguration configuration)
    {
        _configuration = configuration;
        baseUrl = _configuration["apiEndpoint"];
    }

    public async Task<ApiResponse<string>> CreateRental(CreateRentalInput request)
    {
        if (request == null)
        {
            return new ApiResponse<string>
            {
                StatusCode = 400,
                RequestMethod = "POST",
                Data = "Bad Request"
            };
        }

        string endpoint = baseUrl + "Rental";
        var response = await httpClient.PostAsJsonAsync(endpoint, request);
        var apiResponse = await response.Content.ReadFromJsonAsync<ApiResponse<string>>();

        return apiResponse;
    }
}
