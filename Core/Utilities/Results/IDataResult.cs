using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult
    {
        //işlem sonucu dışında T türünde bir data olucak
        //öreneğin ürün , ürünler
        T Data { get; }
    }
}
