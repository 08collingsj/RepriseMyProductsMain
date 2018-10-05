using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepriseMyProducks.Dtos
{
    public class Product
    {
        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual double Price { get; set; }

        public virtual int StockLevel { get; set; }
    }
}