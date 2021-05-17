using API.BO;
using System.Threading.Tasks;

namespace BLLC.Services
{
   public interface IRestaurantService
    {
        Task<Plat> CreatePlat(Plat plat);
    }
}