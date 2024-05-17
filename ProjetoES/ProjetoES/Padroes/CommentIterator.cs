namespace ProjetoES.Padroes
{
	public class CommentIterator : IEnumerator<ICommentItem>
	{
		private int position { get; set; } = -1;
		private ICommentItem[] items { get; }

		public CommentIterator(ICommentItem[] aItems)
		{
			items = aItems;
		}

		object IEnumerator.Current => Current;

		public ICommentItem Current
		{
			get
			{
				if (position < items.Length) return items[position];
				return null;
			}
		}

		public bool MoveNext()
		{
			position++;
			return(position < items.Length);
		}

		public void Reset()
		{
			position = -1;
		}

		public bool HasNext()
		{
			return true;
		}

		public void Dispose() { 
		}
	}
}
