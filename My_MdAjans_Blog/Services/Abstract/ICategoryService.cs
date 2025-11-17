using My_MdAjans_Blog.Entities;
using My_MdAjans_Blog.Models.CategoryModels;

namespace My_MdAjans_Blog.Services.Abstract
{
	public interface ICategoryService//kategori servisi interface i
	{
		ServiceResponse<List<Category>> List();
		ServiceResponse<Category> CreateCategory(CategoryViewModel model, HttpContent httpContent);//service response döndüren createcategory metodu ayriyeten httpcontent parametresi ile session alıyoruz 
	
		ServiceResponse<Category> Find(int id);

		ServiceResponse<object> Remove(int id);

		ServiceResponse<Category> UpdateCategory(int id, CategoryEditViewModel model/*, HttpContent httpContent*/);


	}
}
