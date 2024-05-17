using Microsoft.Extensions.Hosting;

namespace ProjetoES.Models
{
    public class Forum
    {
        public List<Post> Posts { get; set; }

        public void AddPost(Post post)  // Alterado para singular
        {
            Posts.Add(post);
        }

        public void RemovePost(Post post)  // Alterado para singular
        {
            Posts.Remove(post);
        }
    }
}
