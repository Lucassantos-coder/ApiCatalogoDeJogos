using ApiCatalogoJogos.InputModel;
using ApiCatalogoJogos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Services
{
	public interface IJogoSerices : IDisposable
	{
		Task<List<JogoViewModel>> Obter(int pagina, int qauntidade);
		Task<JogoViewModel> Obter(Guid id);
		Task<JogoViewModel> Inserir(JogoInputModel jogo);
		Task Atualizar(Guid id, JogoInputModel jogo);
		Task Atualizar(Guid id, double preco);
		Task Remover(Guid id);
	}
}
