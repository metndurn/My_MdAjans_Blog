using System.ComponentModel.DataAnnotations;

namespace My_MdAjans_Blog.Models
{
	public class CategoryViewModel //kategori modelidir entity den alındı
	{

		[Required, StringLength(40), Display(Name = "Kategori Adı")]
		public string Name { get; set; }

		[StringLength(200), Display(Name = "Açıklama")]
		public string Description { get; set; }

	}
}
