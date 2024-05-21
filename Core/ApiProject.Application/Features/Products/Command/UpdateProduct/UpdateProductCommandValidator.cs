﻿using ApiProject.Domain.Entities;
using FluentValidation;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Application.Features.Products.Command.UpdateProduct
{
    public class UpdateProductCommandValidator:AbstractValidator<UpdateProductCommandRequest>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .WithName("Başlıq");

            RuleFor(x => x.Description)
                .NotEmpty()
                .WithName("Açıqlama");

            RuleFor(x => x.BrandId)
                .GreaterThan(0)
                .WithName("Marka");

            RuleFor(x => x.Price).
                GreaterThan(0)
                .WithName("Qiymət");

            RuleFor(x => x.Discount)
                .GreaterThanOrEqualTo(0)
                .WithName("Endirim");

            RuleFor(x => x.CategoryList)
                .NotEmpty()
                .Must(categories => categories.Any())
                .WithName("Kateqoriyalar");
        }
    }
}
