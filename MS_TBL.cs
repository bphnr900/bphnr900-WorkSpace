using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class MS_TBL
    {
        [Key]
        public Decimal ID { get; set; }
        public string 機体番号{ get; set; }
        public string 機体名 { get; set; }
        public string 登場作品 { get; set; }

        public virtual ICollection<TITLE_NAME> TITLE_NAMEs { get; set; }
    }
}