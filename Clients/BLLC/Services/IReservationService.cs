using BO.DTO;
using BO.DTO.Responses;
using BO.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLLC.Services
{
    public interface IReservationService
    {
        Task<Reservation> CreateReservation(Reservation reservation);
        Task<PageResponse<Reservation>> GetAllReservations(PageRequest pageRequest);
        
        Task<Reservation> ModernPostReservation(Reservation reservation);
    }
}