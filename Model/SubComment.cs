namespace BLogProject.Model
{
	public class SubComment
	{
		public int Id { get; set; }
        public int MainCommentId { get; set; }
        public string Username { get; set; } = "";
		public string Content { get; set;} = "";
    }
}
