using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01
{
    public class Person : BindableBase
    {
        public enum Gender
        {
            None,
            Men,
            Women
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender gender { get; set; }
    }
}
