using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.cs.GameStore.Services.Contracts
{
    public interface IGameService
    {
        void Create(
            string title,
            string description,
            string image,
            decimal price,
            double size,
            string videoId,
            DateTime releaseDate);

     //   IEnumerable<AdminListGameViewModel> All();
    }
}