using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CategoryManager
    {
        Repository<Category> caterepo = new Repository<Category>();

        public List<Category> GetAll()
        {
            return caterepo.List();
        }
        
    }
}
