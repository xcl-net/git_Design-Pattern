using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._6简历的深复制实现
{
    class Resume:ICloneable
    {
        private string name;
        private string sex;
        private string age;
        /// <summary>
        /// 引用工作经历对象
        /// </summary>
        private WorkExperience work;
        public Resume(string name)
        {
            this.name = name;
            //在简历类实例化时候同时实例化“工作经历”
            work = new WorkExperience();
        }
        /// <summary>
        /// 提供Clone方法调用的私有构造函数，以便克隆“工作经历”的数据
        /// </summary>
        /// <param name="work"></param>
        private Resume(WorkExperience work)
        {
            this.work = (WorkExperience) work.Clone();
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
            //调用私有的构造方法：让“工作经历”克隆完成，然后再给这个“简历”对象的相关字段赋值，最终返回一个深复制的简历对象
            Resume obj=new Resume(this.work);
            obj.name = this.name;
            obj.sex = this.sex;
            obj.age = this.age;
            return obj;
        }
    }
}
