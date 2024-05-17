
using ProjetoES.Models;

namespace Projeto_ES.Server.Padroes
{
    public class PostsIterator : IIterator
    {
        private  Post[] posts;
        private int position = 0;

        public PostsIterator(Post[] posts)
        {
            this.posts = posts;
        }

        public bool HasNext()
        {
            return position < posts.Length;
        }

        public Post? Next()
        {
            if (HasNext())
            {
                Post post = posts[position];
                position++;
                return post;
            }
            return null;
        }

		
	}
}