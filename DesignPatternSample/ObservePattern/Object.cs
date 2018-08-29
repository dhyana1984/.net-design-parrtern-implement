using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapmlePrj.Observe
{
    public interface IObject
    {

        IList<IMonitor> ListMonitor { get; set; } //定义观察者集合，因为多个观察者观察一个对象，所以这里用集合
        string SubjectState { get; set; }        //被观察者的状态
     

        void AddMonitor(IMonitor monitor);  //添加一个观察者

        void RemoveMonitor(IMonitor monitor); //移除一个观察者

        void SendMessage(); //向所有观察者发送消息

    }
    public class Subject : IObject
    {


        private IList<IMonitor> listMonitor = new List<IMonitor>();

        public string SubjectState //被观察者的状态
        {
            get;set;
        }


        public IList<IMonitor> ListMonitor //实现具体的观察者列表属性
        {
            get { return listMonitor; }
            set { listMonitor = value; }
        }

        public void AddMonitor(IMonitor monitor)  //实现具体的添加观察者方法
        {
            listMonitor.Add(monitor);
        
        }

        public void RemoveMonitor(IMonitor monitor) //实现具体的移除观察者方法
        {
           
            listMonitor.Remove(monitor);
        }

        public void SendMessage()    //实现具体的发送消息方法
        {
            foreach (IMonitor m in listMonitor)  //发送给所有添加过的观察者，让观察者执行update方法以同步更新自身状态
            {
                m.Update();
            }
        }
    }
}
