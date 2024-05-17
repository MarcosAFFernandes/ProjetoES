namespace Projeto_ES.Server.Padroes
{
	class CompositeComment : ICommentItem
	{
		private readonly List<ICommentItem> commentItems = new List<ICommentItem>();

		public string Username { get; }
		public string Texto { get; }
		public int ID { get; }

		public CompositeComment(string user, string texto)
		{
			Username = user;
			Texto = texto;
		}

		public void AddItem(ICommentItem item) => commentItems.Add(item);
		public void RemoveItem(ICommentItem item) => commentItems.Remove(item);

		public void Display() { }
	}
}
