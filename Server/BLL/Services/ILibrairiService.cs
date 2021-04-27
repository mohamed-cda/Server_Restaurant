using API.BusinessObject;
using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IRestaurantService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns></returns>
        Task<Reservation> CreateReservation(Reservation reservation);

        Task<List<Reservation>> GetAllReservations();

        Task<PageResponse<Reservation>> GetAllReservation(PageRequest pageRequest);

        Task<Reservation> GetReservationById(int id);

        Task<Reservation> ModifyReservation(Reservation reservation);

        Task<bool> RemoveResrvationById(int id);

    }
}