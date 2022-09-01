using DataModels;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var db = new OfflineDataDB())
            {

                var bjsProduct = db.BjsProducts.Select(x => new { x.Id, x.CategoryId, x.Name, x.Pdplink, x.Manufacturer, x.Partnumber, x.ProductPrice, x.ProductUrl, x.Upc, x.Upc12, x.Ean, x.Plu, x.Image, x.Itemid, x.ShortName, x.ManufacturerPartNumber, x.Articleid, x.CreatedAt, x.UpdatedAt});

                foreach (var item in bjsProduct)
                {

                    string result = JsonConvert.SerializeObject(item);
                    //  Console.WriteLine(result);
                    //creation and naming of each file
                    var myUniqueFileName = string.Format(@"{0}.Json", DateTime.Now.Ticks);
                    File.WriteAllText(myUniqueFileName, result);

                    Console.WriteLine("File Created");
                }
            }

        }
    }
}
