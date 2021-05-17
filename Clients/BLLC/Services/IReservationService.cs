using API.BusinessObject;
using BO.DTO.Requests;
using BO.DTO.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLLC.Services
{
    public interface IReservationService
    {
        Task<Reservation> CreateReservation(Reservation reservation);
        Task<PageResponse<Reservation>> GetAllReservations(PageRequest pageRequest);
        Task<List<Reservation>> ModernGetAllReservations();
        Task<Reservation> ModernPostReservation(Reservation reservation);
    }
}