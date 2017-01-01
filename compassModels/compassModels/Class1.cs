using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compassModels.model
{
    public class Product
    {
        private String prodCode;

        public String ProdCode
        {
            get { return this.prodCode; }
            set { prodCode = value; }
        }

        private String prodName;

        public String ProdName
        {
            get { return prodName; }
            set { prodName = value; }
        }

        private DateTime effDate;

        public DateTime EffDate
        {
            get { return effDate; }
            set { effDate = value; }
        }
 


    }
}
