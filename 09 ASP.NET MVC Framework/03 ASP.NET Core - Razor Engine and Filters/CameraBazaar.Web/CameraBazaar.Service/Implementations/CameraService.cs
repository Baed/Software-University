using CameraBazaar.Data;
using CameraBazaar.Data.Enums;
using CameraBazaar.Data.Models;
using CameraBazaar.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraBazaar.Service.Implementations
{
    public class CameraService : ICameraService
    {
        private readonly CameraBazaarDbContext db;

        public CameraService(CameraBazaarDbContext db)
        {
            this.db = db;
        }

        public void Create(CameraMakeType make, string model, decimal price, double quantity, int minShutter, int maxShutter, MinISOType minISO, int maxISO, bool isFullFrame, string resolution, IEnumerable<LightMateringType> lightMatering, string description, string imageUrl, string userId)
        {
            //  if (lightMatering == null)
            //  {
            //      lightMatering = new List<LightMateringType>();
            //  }

            var camera = new Camera
            {
                Model = model,
                Price = price,
                Quantity = quantity,
                MinShutter = minShutter,
                MaxShutter = maxShutter,
                MinISO = minISO,
                MaxISO = maxISO,
                IsFullFrame = isFullFrame,
                Resolution = resolution,
                LightMatering = (LightMateringType)lightMatering.Cast<int>().Sum(),
                Description = description,
                ImageUrl = imageUrl,
                UserId = userId
            };

            this.db.Cameras.Add(camera);

            this.db.SaveChanges();
        }

        public bool Edit(int id, CameraMakeType make, string model, decimal price, double quantity, int minShutter, int maxShutter, MinISOType minISO, int maxISO, bool isFullFrame, string resolution, IEnumerable<LightMateringType> lightMatering, string description, string imageUrl, string userId)
        {
            var camera = this.db
                .Cameras
                .FirstOrDefault(c => c.Id == id && c.UserId == userId);

            if (camera == null)
            {
                return false;
            }

            camera.Model = model;
            camera.Make = make;
            camera.Price = price;
            camera.Quantity = quantity;
            camera.MinShutter = minShutter;
            camera.MaxShutter = maxShutter;
            camera.MinISO = minISO;
            camera.MaxISO = maxISO;
            camera.IsFullFrame = isFullFrame;
            camera.Resolution = resolution;
            camera.LightMatering = (LightMateringType)lightMatering.Cast<int>().Sum();
            camera.Description = description;
            camera.ImageUrl = imageUrl;

            this.db.SaveChanges();

            return true;
        }

        public bool IsCameraExists(int id, string userId)
        {
            return this.db
                .Cameras
                .Any(c => c.Id == id && c.UserId == userId);
        }
    }
}

