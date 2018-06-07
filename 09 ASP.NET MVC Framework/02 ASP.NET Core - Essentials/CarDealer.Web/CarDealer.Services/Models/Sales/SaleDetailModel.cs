using CarDealer.Services.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Services.Models.Sales
{
    public class SaleDetailModel : SaleListModel
    {
       public CarModel Car { get; set; }

    }
}
