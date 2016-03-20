using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._5浅复制与深复制
{
    /// <summary>
    /// 简历类
    /// </summary>
    class Resume
    {
        private string name;
        private string sex;
        private string age;
        private string timeArea;
        private string company;

        /// <summary>
        /// 引用工作经历对象
        /// </summary>
        private WorkExperience work;
        public Resume(string name)
        {
            this.name = name;
            //在简历类实例化时候同时实例化“工作经历”
            work=new WorkExperience();
        }
        /// <summary>
        /// 设置个人信息
        /// </summary>
        /// <param name="sex"></param>
        /// <param name="age"></param>
        public void SetPersonalInfo(string sex, string age)
        {
            this.age = age;
            this.sex = sex;
        }
        /// <summary>
        /// 设置工作经历
        /// </summary>
        /// <param name="workDate"></param>
        /// <param name="company"></param>
        public void SetWorkExperience(string workDate, string company)
        {
            work.WorkDate = workDate;
            work.Company = company;
        }
        /// <summary>
        /// 显示
        /// </summary>
        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", name, sex, age);
            Console.WriteLine("工作经历：{0} {1}", work.WorkDate, work.Company);
        }

        public object Clone()
        {
            return (object)this.MemberwiseClone();
        }
    }
}
