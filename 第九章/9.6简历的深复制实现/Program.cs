using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._6简历的深复制实现
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("大鸟");
            a.SetPersonalInfo("男", "23");
            a.SetWorkExperience("2008-2020", "xx公司");

            //克隆a
            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("1200-1222", "yy公司");

            Resume c = (Resume)a.Clone();
            b.SetWorkExperience("2009-2023", "zz公司");

            a.Display();
            b.Display();
            c.Display();

            Console.Read();
        }
    }
}
