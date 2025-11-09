using System.ComponentModel.DataAnnotations;

namespace My_MdAjans_Blog.Entities
{
	public class Comment
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Metin Alanının Girilmesi Zorunludur.."),StringLength(250),Display(Name = "Yorum")]
		public string Text { get; set; }

		[Display(Name = "Onay Durumu")]
		public int? UserId { get; set; }//null olması ıcın ? işaret konuldu yani boş bırakılabilir
		
		public virtual User User { get; set; }//ilişki kurulacak tablo yani bir kullanıcıya ait yorumlar

		[Display(Name = "Notlar")]
		public int? NoteId { get; set; }//bir yorumun bir nota ait olması için kullanılır ve null olabilir
		public virtual Note Note { get; set; }//ilişki kurulacak tablo yani bir nota ait yorumlar
	}
}
