namespace BLogProject.Model
{
	public class MainComment
	{
		public int Id { get; set; }
		public string Username { get; set; } = string.Empty;
		public string Content { get; set; } = string.Empty;
		public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int BlogId { get; set; }
        public List<SubComment> SubComments { get; set; } = new List<SubComment>();
	}
}
