using System;
using Newtonsoft.Json;
using RentCarClient.Models.Output;
using RentCarClient.Service;

namespace RentCarClient.Handlers;

public class CarHandler : ICar
{
    private readonly IConfiguration _configuration;
    private readonly string baseUrl = "";
    private HttpClient httpClient = new HttpClient();

    public CarHandler(IConfiguration configuration)
    {
        _configuration = configuration;
        baseUrl = _configuration["apiEndpoint"];
    }

    public async Task<ApiResponse<IEnumerable<GetCarOutput>>> GetCar()
    {
        string endpoint = baseUrl + "Car";
        var carOutput = new ApiResponse<IEnumerable<GetCarOutput>>();
        var response = await httpClient.GetAsync(endpoint);
        string apiResponse = await response.Content.ReadAsStringAsync();

        if (!string.IsNullOrEmpty(apiResponse))
        {
            carOutput = JsonConvert.DeserializeObject<ApiResponse<IEnumerable<GetCarOutput>>>(apiResponse);
        }

        return carOutput;
    }
}
