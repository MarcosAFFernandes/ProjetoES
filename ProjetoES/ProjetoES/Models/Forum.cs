namespace ProjetoES.Models
{
    public class Forum
    {

        private static Forum _instance;
        public List<Post> Posts { get; set; }
        public Forum()
        {
            Posts = new List<Post>();
        }

        public static Forum GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Forum();
            }
            return _instance;
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
