using DesafioPleno.Domain.Entidades;

namespace DesafioPleno.Domain.Interfaces
{
    public interface ICarrinhoRepository
    {
        Carrinho Salvar(Carrinho item);
    }
}
