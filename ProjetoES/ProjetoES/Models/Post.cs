using Projeto_ES.Server.Padroes;

namespace ProjetoES.Models
{
    public class Post
    {
        public string user { get; set; }
        public int ID { get; set; }
        public string titulo { get; set; }
        public string texto { get; set; }

        private readonly List<ICommentItem> comments = new List<ICommentItem>();

        public Post(string User, string Titulo, string Texto)
        {
            user = User;
            titulo = Titulo;
            texto = Texto;
        }

        public void addComment(ICommentItem comment)
        {
            comments.Add(comment);
        }

        public void removeComment(ICommentItem comment)
        {
            comments.Remove(comment);
        }


    }
}
