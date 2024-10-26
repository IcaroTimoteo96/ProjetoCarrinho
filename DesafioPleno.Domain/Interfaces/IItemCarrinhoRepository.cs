using DesafioPleno.Domain.Entidades;

namespace DesafioPleno.Domain.Interfaces
{
    public interface IItemCarrinhoRepository
    {
        void Salvar(ItemCarrinho item);
        void Atualizar(ItemCarrinho item);
        void RemoverItem(ItemCarrinho item);
        ItemCarrinho BuscarItemPorID(long id);
        ItemCarrinho BuscarItemPorProdutoID(long id);
        List<ItemCarrinho> BuscarItens(long carrinhoId);
    }
}
