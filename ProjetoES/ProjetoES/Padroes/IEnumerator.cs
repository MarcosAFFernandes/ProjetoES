namespace ProjetoES.Padroes;

public interface IEnumerator
{
	Object Current { get; }
	bool HasNext();
	void Reset();
}

interface IEnumerator<out T> : IEnumerator, IDisposable
{
	T Current { get; }
}

interface IEnumerable
{
	IEnumerator GetEnumerator();
}

interface IEnumerable<out T> : IEnumerable
{
	IEnumerator<T> GetEnumerator();
}