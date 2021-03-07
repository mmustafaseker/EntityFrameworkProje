﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);
        List<Product> GetByUnitePrice(decimal min, decimal max);
        List<ProductDetailDto> GetProductdetails();
        //tek başına bir ürün döndürür
        Product GetById(int productId);

        // ben artık IResult'ım
        IResult Add(Product product);
    }
}
