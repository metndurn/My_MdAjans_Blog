using My_MdAjans_Blog.Entities;
using My_MdAjans_Blog.Models;
using My_MdAjans_Blog.Services.Abstract;

namespace My_MdAjans_Blog.Services.Concrete
{
	public class CategoryService : ICategoryService //kategori servisi sınıfı ICategoryService interface'ini implemente ediyor
	{
		public ServiceResponse<Category> CreateCategory(CategoryViewModel model, HttpContent httpContent)
		{
			throw new NotImplementedException();
		}

		public ServiceResponse<Category> Find(int id)
		{
			throw new NotImplementedException();
		}

		public ServiceResponse<List<Category>> List()
		{
			throw new NotImplementedException();
		}

		public ServiceResponse<object> Remove(int id)
		{
			throw new NotImplementedException();
		}

		public ServiceResponse<Category> UpdateCategory(int id, CategoryEditViewModel model)
		{
			throw new NotImplementedException();
		}
	}
}
