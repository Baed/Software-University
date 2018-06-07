using CameraBazaar.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraBazaar.Data.Models
{
    public class Camera
    {
        public int Id { get; set; }

        public CameraMakeType Make { get; set; }

        [Required]
        [MaxLength(100)]
        public string Model { get; set; }

        public decimal Price { get; set; }

        [Range(0, 100)]
        public double Quantity { get; set; }

        [Range(1, 30)]
        public int MinShutter { get; set; }

        [Range(2000, 8000)]
        public int MaxShutter { get; set; }

        public MinISOType MinISO { get; set; }

        [Range(200, 409600)] 
        public int MaxISO { get; set; }

        public bool IsFullFrame { get; set; }

        [Required]
        [MaxLength(15)]
        public string Resolution { get; set; }

        public LightMateringType LightMatering { get; set; }

        [Required]
        [MaxLength(6000)]
        public string Description { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(2000)]
        public string ImageUrl { get; set; }

        public string UserId { get; set; } // string IdentityUser !!!

        public User User { get; set; }
    }
}
