using ProjetoES.Padroes;

namespace ProjetoES.Models
{
	public class Post
	{
		public String user { get; set; }
		public static int ID { get; set; } = 0;
		public String titulo { get; set; }
		public String texto { get; set; }
		public int id {  get; set; }

		private readonly List<ICommentItem> comments = new List<ICommentItem>();

		public Post(String User, String Titulo, String Texto)
		{
			user = User;
			titulo = Titulo;
			texto = Texto;
			id = ID;
			ID++;
        }
		
		public void AddComment(ICommentItem comment)
		{
			comments.Add(comment);
		}

		public void RemoveComment(ICommentItem comment)
		{
			comments.Remove(comment);
		}

		public int getID()
		{
			return ID;
		}
	}
}
