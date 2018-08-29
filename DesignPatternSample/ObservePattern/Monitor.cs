using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapmlePrj.Observe
{
   public interface IMonitor //定义观察者接口
    {
        void Update(); 
    }


    public class Monitor : IMonitor   //实现具体观察者
    {
        private string monitorState="Stop!";    //观察者初始状态，会随着被观察者变化而变化
        private string name;            //观察者名称，用于标记不同观察者
        private IObject subject;        //被观察者对象



        public Monitor (IObject subject, string name)  //在构造观察者时，注入被观察者对象，以及标识该观察者名称
        {
            this.subject = subject;
            this.name = name;
            Console.WriteLine("我是观察者{0}，我的初始状态是{1}", name, monitorState);


        }


        public void Update()                           //当被观察者状态改变，观察者需要随之改变
        {
            monitorState = subject.SubjectState;
            Console.WriteLine("我是观察者{0}，我的状态是{1}", name, monitorState);

        }
    }
}
