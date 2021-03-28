using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //interface methodları default publictir.
    //Ama kendi değildir.
    public interface IProductDal:IEntityRepository<Product>
    {
       
    }
}
 