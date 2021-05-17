using API.BusinessObject;
using BLL.Services;
using BO.DTO.Requests;
using BO.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Services
{
    class FakeReservationService : IReservationService
    {
        private List<Reservation> ReservationDB = new List<Reservation>()
        {
            new Reservation(1, DateTime.Now, "premier", "prenom1", "téléphone1", true, 1, "formule1"),
            new Reservation(2, DateTime.Now, "second", "prenom2", "téléphone2", true, 1, "formule2"),
            new Reservation(3, DateTime.Now, "troisième", "prenom3", "téléphone3", true, 1, "formule3"),
            new Reservation(4, DateTime.Now, "quatrième", "prenom4", "téléphone4", true, 1, "formule4"),
            new Reservation(5, DateTime.Now, "cinquième", "prenom5", "téléphone5", true, 1, "formule5")
        };
        public Task<Reservation> CreateReservation(Reservation reservation)
        {
            return Task.FromResult(reservation);
        }

        public Task<List<Reservation>> GetAllReservations()
        {
            return Task.FromResult(ReservationDB);
        }

        public Task<PageResponse<Reservation>> GetAllReservations(PageRequest pageRequest)
        {
            List<Reservation> data = null;
            if (pageRequest.Page * pageRequest.PageSize < ReservationDB.Count)
            {
                int firstIndex = pageRequest.Page * pageRequest.PageSize;
                int lastIndex = (pageRequest.Page * pageRequest.PageSize) + pageRequest.PageSize - 1;
                Math.Clamp(lastIndex, 0, ReservationDB.Count);

                data = ReservationDB.GetRange(firstIndex, lastIndex - firstIndex);

            }
            return Task.FromResult(new PageResponse<Reservation>()
            {
                Page = pageRequest.Page,
                PageSize = pageRequest.PageSize,
                TotalRecords = ReservationDB.Count,
                Data = data
            });
            
        }

        private Task<PageResponse<T>> PageResponse<T>()
        {
            throw new NotImplementedException();
        }

        public Task<Reservation> GetReservationById(int id)
        {
            return Task.FromResult(ReservationDB.Find(b => b.Id == id));
        }

        public Task<Reservation> ModifyReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveReservationById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
