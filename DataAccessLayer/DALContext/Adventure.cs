using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALContext
{
    public class Adventure
    {
        public List<User> players { get; set; }
        public User GM { get; set; }

    }
}
