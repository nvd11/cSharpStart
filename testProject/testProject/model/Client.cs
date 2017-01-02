using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.model
{
    class Client
    {

        public Client()
        {
        }

        public Client(String code, String name)
        {
            this.code = code;
            this.name = name;
        }

        private String code;

        public String Code
        {
            get { return code; }
            set { code = value; }
        }

        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return this.code + " " + this.name;
        }
    }
}
