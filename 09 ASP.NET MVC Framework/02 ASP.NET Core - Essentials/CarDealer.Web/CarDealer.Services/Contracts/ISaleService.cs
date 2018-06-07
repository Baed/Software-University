using CarDealer.Services.Models.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Services.Contracts
{
    public interface ISaleService
    {
        IEnumerable<SaleListModel> GetAll();

        SaleDetailModel GetDetail(int id);
    }
}
