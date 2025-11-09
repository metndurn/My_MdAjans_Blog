using System.ComponentModel.DataAnnotations;

namespace My_MdAjans_Blog.Entities
{
	public class Category : EntityLogBase //kategori sınıfı entitylogbase den kalıtım alıyor
	{
		[Key]
		public int Id { get; set; }

		[Required,StringLength(40),Display(Name="Kategori Adı")]
		public string Name { get; set; }

		[StringLength(200), Display(Name = "Açıklama")]
		public string Description { get; set; }

		public virtual List<Note> Notes { get; set; }
	}
}
