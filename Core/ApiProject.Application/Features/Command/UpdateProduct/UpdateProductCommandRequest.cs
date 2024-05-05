﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Application.Features.Command.UpdateProduct
{
    public class UpdateProductCommandRequest:IRequest
    {
        public int Id {  get; set; }    
        public string Title { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }

        public IList<int> CategoryList { get; set; }
    }
}
