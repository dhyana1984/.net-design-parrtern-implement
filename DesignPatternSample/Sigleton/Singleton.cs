using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapmlePrj.Sigleton
{
    public class Singleton
    {
        private Singleton() { }                     //关键点0：构造函数是私有的
        private static volatile Singleton single = null;    //关键点1：声明单例对象是静态的
        private static object obj = new object();
        public static Singleton GetInstance()      //通过静态方法来构造对象
        {
            if (single == null)                   //关键点2：判断单例对象是否已经被构造
            {
                lock (obj)                          //关键点3：加线程锁
                {
                    if (single == null)              //关键点4：二次判断单例是否已经被构造
                    {
                        single = new Singleton();
                    }
                }
            }
            return single;
        }
    }
}
