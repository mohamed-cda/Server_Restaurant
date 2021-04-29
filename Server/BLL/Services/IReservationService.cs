using API.BusinessObject;
using BO.DTO.Requests;
using BO.DTO.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IReservationService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns></returns>
        Task<Reservation> CreateReservation(Reservation reservation);

        Task<List<Reservation>> GetAllReservations();
        Task<PageResponse<Reservation>> GetAllReservations(PageRequest pageRequest);

       

        Task<Reservation> GetReservationById(int id);

        Task<Reservation> ModifyReservation(Reservation reservation);

        Task<bool> RemoveReservationById(int id);

    }
}