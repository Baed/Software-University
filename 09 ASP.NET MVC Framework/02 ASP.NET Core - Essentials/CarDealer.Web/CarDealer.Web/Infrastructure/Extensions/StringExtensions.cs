using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Web.Infrastructure.Extensions
{
    public static class StringExtensions
    {
        private const string NUMBER_FORMAT = "F2";

        public static string ToPrice(this decimal priceText)
        {
            return $"${priceText.ToString(NUMBER_FORMAT)}";
        }

        public static string ToPercentage(this double percentageText)
        {
            return $"{(percentageText * 100).ToString(NUMBER_FORMAT)}%";
        }
    }
}
