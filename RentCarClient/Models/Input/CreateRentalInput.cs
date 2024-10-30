using System;

namespace RentCarClient.Models.Input;

public class CreateRentalInput
{
    public DateTime rental_date { get; set; }
    public DateTime return_date { get; set; }
    public decimal total_price { get; set; }
    public bool payment_status { get; set; }
    public string customer_id { get; set; }
    public string car_id { get; set; }
}
