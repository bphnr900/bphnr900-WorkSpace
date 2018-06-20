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
        public ObservableCollection<Person> people { get; set; }
        public DelegateCommand command { get; set; }

        public ObservableCollection<Task> tasks { get; set; }

        public Sample()
        {
            people = new ObservableCollection<Person>
            {
                new Person{Name = "tiger",Age = 20, gender= Person.Gender.Men},
                new Person{Name = "scott",Age = 25,gender = Person.Gender.Women}
            };

            tasks = new ObservableCollection<Task>
            {
                new Task{isCheck = false,StartTime=DateTime.Now.ToString("HH:mm")}
            };

            this.command = new DelegateCommand(this.execute, this.canexecute);
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

    }
}
