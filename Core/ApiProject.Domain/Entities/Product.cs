﻿using ApiProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Domain.Entities
{
    public class Product:EntitieBase
    {

        public Product()
        {
            
        }


        public Product(string Title, string Description, int BrandId, decimal Price, decimal Discount)
        {
            this.Title = Title;
            this.Description = Description;
            this.BrandId = BrandId;
            this.Price = Price;
            this.Discount = Discount;
        }


        public  string Title { get; set; }
        public  string Description { get; set; }
        public  int BrandId { get; set; }
        public Brand Brand { get; set; }
        public  decimal Price { get; set; } 
        public  decimal Discount { get; set; }  

        public ICollection<ProductCategory> ProductCategories { get; set; }

    }
}
