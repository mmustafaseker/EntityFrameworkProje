using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        //sadece product'ı değil aynı zamanda işlme sonucu ve mesajı döndürmek istiyorum
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitePrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductdetails();

        //tek başına bir ürün döndürür
        IDataResult<Product> GetById(int productId);

        // ben artık IResult'ım
        IResult Add(Product product);
    }
}
