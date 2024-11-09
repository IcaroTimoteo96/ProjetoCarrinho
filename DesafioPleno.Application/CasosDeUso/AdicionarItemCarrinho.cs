using DesafioPleno.Application.CasosDeUso.Request;
using DesafioPleno.Application.CasosDeUso.Response;
using DesafioPleno.Domain.Entidades;
using DesafioPleno.Domain.Interfaces;

namespace DesafioPleno.Application.CasosDeUso
{
    public class AdicionarItemCarrinho
    {
        private readonly ICarrinhoRepository _carrinhoRepository;
        private readonly IItemCarrinhoRepository _itemCarrinhoRepository;

        public AdicionarItemCarrinho(ICarrinhoRepository carrinhoRepository, IItemCarrinhoRepository itemCarrinhoRepository)
        {
            _carrinhoRepository = carrinhoRepository;
            _itemCarrinhoRepository = itemCarrinhoRepository;
        }

        public BaseResponse<object> AdicionarItem(CarrinhoRequest carrinhoRequest)
        {
            var response = new BaseResponse<object>();

            try
            {
               carrinhoRequest.Itens = carrinhoRequest.Itens
                    .DistinctBy(x => x.ProdutoID)
                    .ToList();

                var carrinho = new Carrinho
                {
                    UserID = carrinhoRequest.UserID,
                };

                carrinho = _carrinhoRepository.Salvar(carrinho);

                foreach (var item in carrinhoRequest.Itens)
                {
                    var existeItemCarrinho = _itemCarrinhoRepository.BuscarItemPorProdutoID(item.ProdutoID);

                    if (existeItemCarrinho != null)
                    {
                        existeItemCarrinho.Quantidade += item.Quantidade;

                        _itemCarrinhoRepository.Atualizar(existeItemCarrinho);
                    }
                    else
                    {
                        var itemCarrinho = new ItemCarrinho
                        {
                            CarrinhoID = carrinho.Id,
                            ProdutoID = item.ProdutoID,
                            PrecoUnitario = item.PrecoUnitario,
                            Quantidade = item.Quantidade
                        };

                        _itemCarrinhoRepository.Salvar(itemCarrinho);
                    }
                }

                response.Success = true;
                response.Message = "O item foi adicionado ao carrinho.";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = $"Erro ao buscar itens: {ex.Message}";
            }

            return response;
        }
    }
}
