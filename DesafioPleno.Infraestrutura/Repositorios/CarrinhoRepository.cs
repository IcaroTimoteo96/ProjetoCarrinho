using DesafioPleno.Domain.Entidades;
using DesafioPleno.Domain.Interfaces;

namespace DesafioPleno.Infraestrutura.Repositorios
{
    public class CarrinhoRepository : ICarrinhoRepository
    {
        private AppDbContext _context;

        public CarrinhoRepository(AppDbContext context) 
        { 
            _context = context;
        }

        public Carrinho Salvar(Carrinho item)
        {
            _context.Carrinhos.Add(item);
            _context.SaveChanges();
            return item;
        }
    }
}
