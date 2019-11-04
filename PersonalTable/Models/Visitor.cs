using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalTable.Models
{
    public class Visitor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }
        public string Adress { get; set; }
        public string Photo { get; set; }
        public string Email { get; set; }

        public DateTime Enter { get; set; }

        public DateTime Exit { get; set; }


    }
}