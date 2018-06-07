using CameraBazaar.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraBazaar.Web.Models.CamerasViewModel
{
    public class CameraFormViewModel
    {
        public CameraMakeType Make { get; set; }

        [Required]
        [StringLength(100)]
        public string Model { get; set; }

        public decimal Price { get; set; }

        [Range(0, 100)]
        public double Quantity { get; set; }

        [Display(Name ="Min Shutter Speed")]
        [Range(1, 30)]
        public int MinShutter { get; set; }

        [Display(Name = "Max Shutter Speed")]   
        [Range(2000, 8000)]
        public int MaxShutter { get; set; }

        [Display(Name = "Min ISO")]
        public MinISOType MinISO { get; set; }

        [Display(Name = "MAx ISO")]
        [Range(200, 409600)]
        public int MaxISO { get; set; }

        [Display(Name = "Is Full Frame")]
        public bool IsFullFrame { get; set; }

        [Display(Name = "Video Resolution")]
        [Required]
        [StringLength(15)]
        public string Resolution { get; set; }

        [Display(Name = "Light Matering")]
        [Required]
        public IEnumerable<LightMateringType> LightMatering { get; set; } = new HashSet<LightMateringType>();

        [Required]
        [StringLength(6000)]
        public string Description { get; set; }

        [Display(Name = "Image Url")]
        [Required]
        [StringLength(2000, MinimumLength = 10)]
        public string ImageUrl { get; set; }
    }
}
