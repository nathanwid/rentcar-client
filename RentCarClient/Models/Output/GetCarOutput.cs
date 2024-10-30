using System;

namespace RentCarClient.Models.Output;

public class GetCarOutput
{
    public required string Car_id { get; set; }
    public string name { get; set; }
    public string model { get; set; }
    public int year { get; set; }
    public string license_plate { get; set; }
    public int number_of_car_seats { get; set; }
    public string transmission { get; set; }
    public decimal price_per_day { get; set; }
    public bool status { get; set; }
}
