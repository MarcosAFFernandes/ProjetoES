using Microsoft.AspNetCore.Components;

namespace ProjetoES.Padroes
{
	public interface ICommentItem
    {
        public string User { get; }
		public string Texto { get; }
		public int ID { get; }

		public RenderFragment RenderComponent();
	}
}