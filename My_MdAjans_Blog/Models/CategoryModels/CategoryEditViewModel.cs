using System.ComponentModel.DataAnnotations;

namespace My_MdAjans_Blog.Models.CategoryModels
{
	public class CategoryEditViewModel//kategori düzenleme modeli
	{
		/*required zorunlu alan stringlength ile maksimum karakter uzunluğu
		 belirleniyor display ile ekranda gözükecek isim belirleniyor
		biz ise guncelleme yapacagımız ıcın burada bos gelmesını ıstıyoruz */
		public string Name { get; set; }

		public string Description { get; set; }

	}
}
