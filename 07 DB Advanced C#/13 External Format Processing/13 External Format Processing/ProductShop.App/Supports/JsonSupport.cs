using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProductShop.App
{
    public class JsonSupport
    {
        public static T[] ImportJson<T>(string path)
        {
            var stringJson = File.ReadAllText(path);

            T[] objects = JsonConvert.DeserializeObject<T[]>(stringJson);

            return objects;
        }
    }
}
