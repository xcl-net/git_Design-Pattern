using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._6简历的深复制实现
{
    /// <summary>
    /// 工作经历类
    /// </summary>
    class WorkExperience : ICloneable
    {
        private string workDate;

        public String WorkDate
        {
            get { return workDate; }
            set { workDate = value; }
        }

        private string company;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        /// <summary>
        /// 工作经历类实现克隆方法
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return (object) this.MemberwiseClone();
        }
    }
}
