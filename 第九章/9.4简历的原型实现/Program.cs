using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._4简历的原型实现
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一个个人信息需要实例化
            Resume a = new Resume("大鸟");
            a.SetPersonalInfo("男", "23");
            a.SetWorkExperience("2009-2012", "xx公司");

            //第二个个人信息只是克隆一下a的就可以了
            //而且工作经历也可以自由的定制；
            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("2023-2012", "yy公司");


            Resume c = (Resume)b.Clone();
            c.SetWorkExperience("2009-2012", "ii公司");

            a.Display();
            b.Display();
            c.Display();
            Console.Read();
        }
    }
}
