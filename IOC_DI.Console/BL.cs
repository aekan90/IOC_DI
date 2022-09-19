using System;
using System.Collections.Generic;
using System.Text;

namespace IOC_DI.ConsoleApp
{
    class BL
    {
        public IDAL _dal { get; set; }

        public BL()
        {
           // _dal = new DAL();  //--> alt satırda Factory pattern ile iptal edildi
           // inversion of control prensibini implement ettik
           _dal = DALFactory.GetDal();
        }
        
        public List<Product> GetProductsOnBL()
        {
            return _dal.GetProducts();
        }

    }
}
