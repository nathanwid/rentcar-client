using System;
using Microsoft.AspNetCore.Mvc;
using RentCarClient.Models.Input;
using RentCarClient.Models.Output;

namespace RentCarClient.Service;

public interface IRental
{
    Task<ApiResponse<string>> CreateRental(CreateRentalInput request);
}
