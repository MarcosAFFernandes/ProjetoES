namespace ProjetoES.Models
{
    public class Collections
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Movie> Movies { get; set; }
        public Collections(string name)
        {
            Name = name;
            Movies =  new List<Movie>(); ;
        }
    }

}
