using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01
{
    public class Task : BindableBase
    {
        public bool isCheck { get; set; }
        public string TaskName { get; set; }
        public string StartTime { get; set; }

        private string endTime;
        public string EndTime
        {
            get { return endTime; }
            set { this.SetProperty(ref this.endTime, value); }
        }
        public TimeSpan ManHour { get; set; }
    }
}
