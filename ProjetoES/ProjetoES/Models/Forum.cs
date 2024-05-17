namespace ProjetoES.Models
{
    public class Forum
    {

        public List<Post> Posts { get; set; }
        public Forum()
        {
            Posts = new List<Post>();
        }
        public void AddPost(Post post)
        {
            Posts.Add(post);
        }

        public void RemovePost(Post post) 
        {
            Posts.Remove(post);
        }
    }
}
