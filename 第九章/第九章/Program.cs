using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第九章
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //第一个个人信息
            Resume a=new Resume("大鸟");
            a.SetPersonalInfo("男","23");
            a.SetWorkExperience("2009-2012","xx公司");
            
            //第二个个人信息
            Resume b= new Resume("大鸟");
            b.SetPersonalInfo("男", "23");
            b.SetWorkExperience("2009-2012", "xx公司");

            Resume c = new Resume("大鸟");
            c.SetPersonalInfo("男", "23");
            c.SetWorkExperience("2009-2012", "xx公司");

            a.Display();
            b.Display();
            c.Display();
             */
            //弊端：如果第一个出错，接下来复制的信息，同样会出错，都复制一遍；
            //修改代码如下，只是修改一次即可：
            //如下：
            Resume a=new Resume("大鸟");
            a.SetPersonalInfo("男","23");
            a.SetWorkExperience("2009-2012","xx公司");

            Resume b = a;
            Resume c = a;

            a.Display();
            b.Display();
            c.Display();

            Console.Read();
        }
    }
}
