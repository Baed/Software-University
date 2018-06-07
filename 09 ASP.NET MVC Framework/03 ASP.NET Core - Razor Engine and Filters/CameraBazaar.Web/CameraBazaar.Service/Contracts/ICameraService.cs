using CameraBazaar.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraBazaar.Service.Contracts
{
    public interface ICameraService
    {
        void Create(
        CameraMakeType make,
        string model,
        decimal price,
        double quantity,
        int minShutter,
        int maxShutter,
        MinISOType minISO,
        int maxISO,
        bool isFullFrame,
        string resolution,
        IEnumerable<LightMateringType> lightMatering,
        string description,
        string imageUrl,
        string userId);

        bool Edit(
        int id,
        CameraMakeType make,
        string model,
        decimal price,
        double quantity,
        int minShutter,
        int maxShutter,
        MinISOType minISO,
        int maxISO,
        bool isFullFrame,
        string resolution,
        IEnumerable<LightMateringType> lightMatering,
        string description,
        string imageUrl,
        string userId);

        bool IsCameraExists(int id, string userId);
    }
}
