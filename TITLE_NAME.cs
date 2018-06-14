using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class TITLE_NAME
    {
        [Key]
        public decimal ID { get; set; }
        public string 作品名 { get; set; }

        public virtual ICollection<MS_TBL> MS_TBLs { get; set; }
    }
}