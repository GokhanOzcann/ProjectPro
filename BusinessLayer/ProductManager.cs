using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductManager
    {
        Repository<Product> prorepo = new Repository<Product>();

        public List<Product> GetAll()
        {
            return prorepo.List();  
        }

    }
}
