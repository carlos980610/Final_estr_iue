using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotriz
{
    class SendClass
    {
        string Id;

       public SendClass()
        {

        }
        public void GetterId(string id)
        {
            Id = id;
        }

        public string SetterId()
        {
            return Id;
        }
    }
}
