using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZCSAPI.DAL.DBModels;
using ZCSAPI.Repository;

namespace ZCSAPI.BLL
{
    public class ProductManager
    {
        public static void AddProduct(Product product)
        {
            ProductRepository proRep = new ProductRepository();
            Guid result = proRep.AddEntity(product);
        }

        public static void AddStore(Store store)
        {
            StoreRepository storeRep = new StoreRepository();
            Guid result = storeRep.AddEntity(store);
        }
    }
}
