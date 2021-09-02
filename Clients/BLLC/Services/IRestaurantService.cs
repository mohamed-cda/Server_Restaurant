using BO.DTO;
using BO.DTO.Responses;
using BO.Entity;
using System.Threading.Tasks;

namespace BLLC.Services
{
    public interface IRestaurantService
    {
        Task<Ingredient> CreateIngredient(Ingredient ingredient);
        Task<PageResponse<Ingredient>> GetAllIngredients(PageRequest pageRequest);
        Task<bool> RemoveIngredientById(Ingredient ingredient);
        Task<PageResponse<Menu>> GetAllMenus(PageRequest pageRequest);
        Task<PageResponse<Plat>> GetAllPlats(PageRequest pageRequest);
        Task<Plat> GetAsync(int id);

        Task<Menu> ModifyMenu(Menu menu);
        Task<Plat> ModifyPlat(Plat plat);
        Task<Menu> PostMenu(Menu menu);
        Task<Plat> CreatePlat(Plat plat);
        Task<bool> RemoveMenuById(Menu menu);
       
    }
}