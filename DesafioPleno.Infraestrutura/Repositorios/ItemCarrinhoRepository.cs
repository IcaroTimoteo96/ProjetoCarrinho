using DesafioPleno.Domain.Entidades;
using DesafioPleno.Domain.Interfaces;

namespace DesafioPleno.Infraestrutura.Repositorios
{
    public class ItemCarrinhoRepository : IItemCarrinhoRepository
    {

        private AppDbContext _context;

        public ItemCarrinhoRepository(AppDbContext context)
        {
            _context = context;
        }

        public ItemCarrinho BuscarItemPorID(long id)
        {
            return _context.ItensCarrinho.FirstOrDefault(x => x.Id == id);
        }

        public ItemCarrinho BuscarItemPorProdutoID(long id)
        {
            return _context.ItensCarrinho.FirstOrDefault(x => x.ProdutoID == id);
        }

        public List<ItemCarrinho> BuscarItens(long carrinhoId)
        {
            return _context.ItensCarrinho.Where(x => x.CarrinhoID == carrinhoId).ToList();
        }

        public void RemoverItem(ItemCarrinho item)
        {
            _context.ItensCarrinho.Remove(item);
            _context.SaveChanges();
        }

        public void Salvar(ItemCarrinho item)
        {
            _context.ItensCarrinho.Add(item);
            _context.SaveChanges();
        }

        public void Atualizar(ItemCarrinho item)
        {
            _context.ItensCarrinho.Attach(item);
            _context.Entry(item).Property(x => x.Quantidade).IsModified = true;
            _context.SaveChanges();
        }
    }
}
