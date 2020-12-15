using ApiVendas.Domain.Models;
using System.Threading.Tasks;

namespace ApiVendas.Domain.Services
{
    public interface IVendasService
    {
        Task GravaVenda(Venda venda);
    }
}
