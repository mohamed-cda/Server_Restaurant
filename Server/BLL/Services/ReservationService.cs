using API.BusinessObject;
using BO.DTO.Requests;
using BO.DTO.Responses;
using DAL.Repository;
using DAL.UOW;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    internal class ReservationService : IReservationService
    {
        private readonly IUnitOfWork _db;

        public ReservationService(IUnitOfWork unitOfWork)
        {
            _db = unitOfWork;
        }

        #region Reservations
        public async Task<Reservation> CreateReservation(Reservation reservation)
        {
            _db.BeginTransaction();
            IReservationRepository _reservations = _db.GetRepository<IReservationRepository>();
            Reservation newReservation = await _reservations.InsertAsync(reservation);
            _db.Commit();
            return newReservation;
        
         }

        public async Task<Reservation> ModifyReservation(Reservation reservation)
        {
            return await Task.FromResult(new Reservation());
        }

        public async Task<bool> RemoveReservationById(int id)
        {
            return await Task.FromResult(true);
        }

        public async Task<PageResponse<Reservation>> GetAllReservations(PageRequest pageRequest)
        {
            IReservationRepository _reservations = _db.GetRepository<IReservationRepository>();

            return await _reservations.GetAllAsync(pageRequest);

        }

        public async Task<Reservation> GetReservationById(int id)
        {
            
            IReservationRepository _Reservations = _db.GetRepository<IReservationRepository>();

            return await _Reservations.GetAsync(id);
        }

       

        

        public Task<List<Reservation>> GetAllReservations()
        {
            throw new System.NotImplementedException();
        }


        #endregion
    }
}
