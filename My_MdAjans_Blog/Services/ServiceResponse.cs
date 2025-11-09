namespace My_MdAjans_Blog.Services
{
	public class ServiceResponse <T>//bu bir generic classdır. T tipi ile çalışır. ve bizim olusturdugumumuz servislerin donus tipini belirler.
	{
		public bool IsError { get; set; }
		public List<string> Errors { get; set; } = new List<string>();
		public T Data { get; set; }
		public void AddError(string errorMessage)
		{ 
			IsError = true;
			Errors.Add(errorMessage);
		}

	}
}
