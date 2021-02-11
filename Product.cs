using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{

    // Entity frameworkteki en önemli mzellikleden birisi veritabanınındaki tabloya karşılık gelne bir class olmasıdır
    //Entity frameworkte conneciton string elzemdir.
    //Linq önemkli bir mimariddir. Nesneler için olan linqtoobjects, entitty için olan linqtoentitys olarak geçiyor, ama mimari aynıdır.

    public class Product
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockAmount { get; set; }

    }
}
