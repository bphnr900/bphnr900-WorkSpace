using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;

namespace Practice01
{
    public class Sample : BindableBase
    {
        public DelegateCommand command { get; set; }
        public DelegateCommand DeleteCommand { get; set; }
        public ObservableCollection<Task> tasks { get; set; }

        public Sample()
        {
            tasks = new ObservableCollection<Task>
            {
                new Task{isCheck = false,StartTime=DateTime.Now.ToString("HH:mm")}
            };

            this.command = new DelegateCommand(this.execute, this.canexecute);
            this.DeleteCommand = new DelegateCommand(this.DeleteExecute, this.CanDeleteExecute);
        }

        public void execute()
        {
            var last = tasks[tasks.Count - 1];
            last.EndTime = DateTime.Now.ToString("HH:mm");
            last.ManHour = DateTime.ParseExact(last.EndTime,"HH:mm",null) - DateTime.ParseExact(last.StartTime,"HH:mm",null);
            tasks.Add(
                new Task { isCheck=false, StartTime=DateTime.Now.ToString("HH:mm") }
            );
        }
        public bool canexecute()
        {
            return true;
        }
        public void DeleteExecute()
        {
            for (int i = tasks.Count - 1; i >= 0; i--)
            {
                if (tasks[i].isCheck == true)
                {
                    tasks.RemoveAt(i);
                }
            }
        }
        public bool CanDeleteExecute()
        {
            for (int i = tasks.Count - 1; i >= 0; i--)
            {
                if (tasks[i].isCheck == true)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
