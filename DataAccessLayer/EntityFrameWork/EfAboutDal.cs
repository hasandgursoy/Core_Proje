using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFrameWork
{   
    // Kendime şu soruyu sormuştum neden GenericRepository ile birlikte IAboutDal'ı implemente ediyoruz.
    // Bunun espirisi şu ilerde crud işlemlerinin dışında bir yapı kullanmak zorunda kalırsak ki kullanacaz.
    // Bunu ilgili Interface'de eklemek genel yapıyı bozmamış olur ve kullanışlı bir yol.
    public class EfAboutDal : GenericRepository<About>,IAboutDal
    {

        

    }
}
