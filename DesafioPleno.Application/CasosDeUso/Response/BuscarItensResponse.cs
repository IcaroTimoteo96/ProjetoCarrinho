using DesafioPleno.Domain.Entidades;

namespace DesafioPleno.Application.CasosDeUso.Response
{
    public class BuscarItensResponse
    {
        public long ProdutoID { get; set; }

        public long Quantidade { get; set; }

        public double PrecoUnitatio { get; set; }
    }
}
