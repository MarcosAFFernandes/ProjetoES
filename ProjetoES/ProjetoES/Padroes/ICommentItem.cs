namespace Projeto_ES.Server.Padroes
{
	public interface ICommentItem
	{
		public string Username { get; }
		public string Texto { get; }
		public static int ID { get; }

		public void Display();
	}
}
