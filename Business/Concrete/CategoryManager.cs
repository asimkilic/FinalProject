using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            //ben category manager olarak veri erişim katmanına bağlıyım ama biraz zayıf bağımlılığım var çünkü interface / referans üzedrinden bağımlıyım o yüzden sen dataacces katmanında istediğin kadar at koşturabilirsin.

            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);
          
        }
    }
}
