using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALContext
{
    public class Rumor
    {
        public string Description { get; set; }

        public DateTime Date { get; set; }

        public Rumor(string description)
        {
            Date = DateTime.Now;
            Description = description;
        }

    }
}
