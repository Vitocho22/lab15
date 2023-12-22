using System;
using System.Collections.Generic;
using System.Text;

namespace lab15.Models
{ 
    public class AirbnbListing
{
    public string Name { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public int PriceUsd { get; set; }
    public string Date { get; set; }
}
}