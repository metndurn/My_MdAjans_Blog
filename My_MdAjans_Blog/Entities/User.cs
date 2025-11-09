using System.ComponentModel.DataAnnotations;

namespace My_MdAjans_Blog.Entities
{
	public class User : EntityLogBase //user sınıfı entitylogbase den kalıtım alıyor
	{
		[Key]
		public int Id { get; set; }
		public string? FullName { get; set; }
		public string? UserName { get; set; }
		public string Email { get; set; }
		public string? Password { get; set; }
		public bool IsActive { get; set; }
		public bool IsAdmin { get; set; }
		public virtual List<Note> Notes { get; set; }//bir kullanıcının birden fazla notu olabilir
	}
}
