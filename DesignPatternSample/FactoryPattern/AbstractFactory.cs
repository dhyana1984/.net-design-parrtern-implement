using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapmlePrj
{
  public  class AbstractFactory
    {
 

        //工厂接口，即抽象工厂
        interface IFactory
        {
            IFridge CreateFridge();
            IAirCondition CreateAirCondition();
        }


        //三星的工厂
        public class SamsungFactory : IFactory
        {
  
            public IAirCondition CreateAirCondition()
            {
                return new SamsungAirCondition();
              
            }

            public IFridge CreateFridge()
            {
                return new SamsungFridge();
            }
        }

        //格力的工厂

        public class GreeFactry : IFactory
        {
            public IAirCondition CreateAirCondition()
            {
                return new GreeAirCondition();
            }

            public IFridge CreateFridge()
            {
                return new GreeFridge();
            }
        }

        //冰箱产品接口
        public interface IFridge
        {
           
        }

        //空调接口
        public interface IAirCondition
        {

        }

        //三星的冰箱
        public class SamsungFridge: IFridge
        {

        }
        //格力的冰箱
        public class GreeFridge : IFridge
        {

        }

        //三星的空调
        public class SamsungAirCondition : IAirCondition
        {

        }
        //格力的空调
        public class GreeAirCondition : IAirCondition
        {

        }




    }
}
