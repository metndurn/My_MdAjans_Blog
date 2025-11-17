using System.ComponentModel.DataAnnotations;

namespace My_MdAjans_Blog.Entities
{
	public class Category : EntityLogBase //kategori sınıfı entitylogbase den kalıtım alıyor
	{
		[Key]
		public int Id { get; set; }

		public virtual List<Note> Notes { get; set; }
	}
}
