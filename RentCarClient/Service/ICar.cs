using System;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using RentCarClient.Models.Output;

namespace RentCarClient.Service;

public interface ICar
{
    Task<ApiResponse<IEnumerable<GetCarOutput>>> GetCar();
}
