using ProjetoES.Padroes;

namespace ProjetoES.Models
{
	public class Post
	{
        public int Id { get; set; }

        public string user { get; set; }
		public string titulo { get; set; }
		public string texto { get; set; }

		private readonly List<ICommentItem> comments = new List<ICommentItem>();

		public Post()
        {
        }
        public Post(String User, String Titulo, String Texto)
		{
			user = User;
			titulo = Titulo;
			texto = Texto;
        }
		
		public void AddComment(ICommentItem comment)
		{
			comments.Add(comment);
		}

		public void RemoveComment(ICommentItem comment)
		{
			comments.Remove(comment);
		}
	}
}
