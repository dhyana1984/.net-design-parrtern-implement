using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapmlePrj
{
    //简单工厂类
   public class SimpleFactory
    {
        int prodNo;
        public SimpleFactory(int prodNo) //构造工厂时告知工厂产品标识
        {
            this.prodNo = prodNo;
        }

        public IProduct GetProduct()
        {
            switch (prodNo) //根据产品标识生产产品
            {
                default:
                    return new ProductA();
                case 1:
                    return new ProductA();
                case 2:
                    return new ProductB();
            }

         }


    }

    ////产品A
    //public class ProductA: IProduct 
    //{
    //    //产品属性
    //    //......
    //}

    ////产品B
    //public class ProductB : IProduct
    //{
    //    //产品属性
    //    //......
    //}

}
