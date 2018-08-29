using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapmlePrj
{
    interface IFactory
    {
        IProduct GetProduct();
    }

    //A工厂类
    public class FactoryA: IFactory
    {
        IProduct productA;
        public FactoryA()
        {
            this.productA = new ProductA();
        }

        public IProduct GetProduct() //A工厂生产A产品
        {
            return this.productA;
        }
    }

    //B工厂类
    public class FactoryB : IFactory
    {
        IProduct productB;
        public FactoryB()
        {
            this.productB = new ProductB();
        }

        public IProduct GetProduct() //B工厂生产B产品
        {
            return this.productB;
        }
    }

    //产品接口
    public interface IProduct
    {
        //产品方法
        //......
    }

    //产品A
    public class ProductA : IProduct
    {
        //产品属性
        //......
    }

    //产品B
    public class ProductB : IProduct
    {
        //产品属性
        //......
    }

}
