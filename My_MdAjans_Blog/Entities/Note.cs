using System.ComponentModel.DataAnnotations;

namespace My_MdAjans_Blog.Entities
{
	public class Note : EntityLogBase //note sınıfı entitylogbase den kalıtım alıyor
	{
		[Key]
		public int Id { get; set; }

		[Required,StringLength(80), Display(Name = "Başlık")]
		public string Title { get; set; }

		[Required,StringLength(300), Display(Name = "Özet")]
		public string Summary { get; set; }

		[Display(Name = "Detay")]
		public string Detail { get; set; }

		[Display(Name = "Taslak")]
		public string IsDraft { get; set; }

		[Display(Name = "Kategori")]
		public int CategoryId { get; set; }//bir not sadece bır kategorıye aıt olur

		[Display(Name = "Yazar")]
		public int OwnerId { get; set; }//bir not sadece bır sahıbı olur
		public virtual User Owner { get; set; }//burada not ile user arasında bir ilişki var diye yazılıyor
		public Category Category { get; set; }
		public virtual List<Comment> Comments { get; set; }//bir not birden fazla yorum alabilir
	}
}
