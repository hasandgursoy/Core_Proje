using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        // ViewComponent yapısı çalışacak olan viewları shared klasorü içindeki ViewComponent içinde arıyor.
        // Ona göre klasör açmamız gerekiyor bu yol değişebilir ancak default olarak böyle.
        // ViewCompenent içnideki Feature List'in içerisine particial view ekliyoruz ancak ismi Default olmak zorunda.
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());

        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetList();
            return View(values);
        }

    }
}
