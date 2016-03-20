using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3原型模式
{
    //原型模式（Prototype）：用原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象[DP]
    class Program
    {
        //原型模式其实就是从一个对象再创建一个可定制的对象，而且不需要知道任何创建的细节。
        static void Main(string[] args)
        {
            //要被大量赋值的对象
            ConcretePrototype1 p1=new ConcretePrototype1("I");

            ConcretePrototype1 c1 = (ConcretePrototype1) p1.Clone();
            ConcretePrototype1 c2 = (ConcretePrototype1) p1.Clone();

            Console.WriteLine("Cloned:{0}",c1.Id);
            Console.WriteLine("Cloned:{0}",c2.Id);
            Console.Read();
        }
    }

    //原型类
    abstract class Prototype
    {
        private string id;

        public Prototype(string id)
        {
            this.id = id;
        }

        public string Id
        {
            get { return id; }
        }

        /// <summary>
        /// 抽象类关键就是有个这样一个Clone方法
        /// </summary>
        /// <returns></returns>
        public abstract Prototype Clone();
    }

    class ConcretePrototype1:Prototype
    {
        public ConcretePrototype1(string id) : base(id)
        {

        }

        public override Prototype Clone()
        {
            
            return (Prototype) this.MemberwiseClone();
        }
    }
}
