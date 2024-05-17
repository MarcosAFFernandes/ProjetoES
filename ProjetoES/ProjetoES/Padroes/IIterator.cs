using ProjetoES.Models;

namespace Projeto_ES.Server.Padroes
{
	public interface IIterator
	{
		bool HasNext();
		Post? Next();
	}
}
