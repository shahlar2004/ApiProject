﻿using ApiProject.Application.Features.Command.UpdateProduct;
using ApiProject.Application.Features.Query.Brands.GetAllBrands;
using ApiProject.Application.Features.Query.Products.GetAllProducts;
using ApiProject.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Application.AutoMapper
{
    internal class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<UpdateProductCommandRequest, Product>().ReverseMap();
            CreateMap<Product,GetAllProductsQueryResponse>().ReverseMap();
        }
    }
}
