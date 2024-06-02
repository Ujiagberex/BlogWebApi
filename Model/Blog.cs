using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace BLogProject.Model
{
	public class Blog
	{
		public int Id { get; set; }
		public string Title { get; set; } = "";
		public string Content { get; set; } = "";	
		public string Tags { get; set; } = "";

		public List<MainComment> Comments { get; set; } = new List<MainComment>();
		public List<SubComment> subComments { get; set; } = new List<SubComment>();
        public List<Like> Likes { get; set; } = new List<Like>();
	}
}
