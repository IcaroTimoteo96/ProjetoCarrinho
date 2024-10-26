using DesafioPleno.Application.CasosDeUso.Response;
using DesafioPleno.Domain.Entidades;
using DesafioPleno.Domain.Interfaces;
using System.Collections.Generic;

namespace DesafioPleno.Application.CasosDeUso
{
    public class BuscarItensCarrinho
    {
        private readonly IItemCarrinhoRepository _itemCarrinhoRepository;

        public BuscarItensCarrinho(IItemCarrinhoRepository itemCarrinhoRepository)
        {
            _itemCarrinhoRepository = itemCarrinhoRepository;
        }

        public BaseResponse<List<BuscarItensResponse>> BuscarItens(long carrinhoId)
        {
            var response = new BaseResponse<List<BuscarItensResponse>>();

            try
            {
                var listaItens = _itemCarrinhoRepository.BuscarItens(carrinhoId);

                var buscarItensResponse = new List<BuscarItensResponse>();

                foreach (var item in listaItens)
                {
                    buscarItensResponse.Add(new BuscarItensResponse
                    {
                        ProdutoID = item.ProdutoID,
                        PrecoUnitatio = item.PrecoUnitario,
                        Quantidade = item.Quantidade
                    });
                }

                response.Data = buscarItensResponse;
                response.Success = true;
                response.Message = "Busca realizada com sucesso!";
            }
            catch(Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;
            }

            return response;
        }
    }
}
