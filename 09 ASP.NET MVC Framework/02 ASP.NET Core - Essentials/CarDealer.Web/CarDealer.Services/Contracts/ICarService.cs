using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Services.Enums;
using CarDealer.Services.Models;
using CarDealer.Services.Models.Cars;

namespace CarDealer.Services.Contracts
{
    public interface ICarService
    {
        IEnumerable<CarModel> ByMake(string make);

        IEnumerable<CarWithPartsModel> WithParts();

        IEnumerable<CarModel> AllCarsList();

        void GetCreate(string make, string model, long travelledDistance, IEnumerable<int> parts);
    }
}
