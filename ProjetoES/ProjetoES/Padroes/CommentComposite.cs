using Microsoft.AspNetCore.Components;

namespace ProjetoES.Padroes
{
    class CompositeComment : ICommentItem
    {
        private readonly List<ICommentItem> commentItems = new List<ICommentItem>();

        public String User { get; }
        public String Texto { get; }
        public int ID { get; }

        public CompositeComment(String user, String texto, int id ):base() {
            User = user;
            Texto = texto;
            ID = id;
        }
        

        public void AddItem(ICommentItem item) => commentItems.Add(item);
        public void RemoveItem(ICommentItem item) => commentItems.Remove(item);

		public List<ICommentItem> GetCommentItems()
		{
			return commentItems;
		}

		public RenderFragment RenderComponent() => builder =>
		{
			// Renderização do CompositeComponent
			builder.OpenElement(0, "div");
			builder.AddContent(0, $"User: {User}");
			builder.AddContent(0, $"Texto: {Texto}");
			foreach (var child in commentItems)
			{
				builder.AddContent(1, child.RenderComponent());
			}
			builder.CloseElement();
		};
	}
}