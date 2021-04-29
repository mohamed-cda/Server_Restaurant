﻿using DAL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Logging;

using API.BusinessObject;
using Microsoft.AspNetCore.Mvc;
using BO.DTO.Requests;
using BO.DTO.Responses;

namespace DAL.Repository
{
    class ReservationRepository : IReservationRepository
    {
        private readonly DbSession _session;
        private readonly ILogger<ReservationRepository> _logger;
        public ReservationRepository(DbSession dbSession, ILogger<ReservationRepository> logger)
        {
            _session = dbSession;
            _logger = logger;
        }

        public Task<int> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<PageResponse<Reservation>> GetAllAsync(PageRequest pageRequest)
        {
            var stmt = @"select * from reservation 
                        ORDER BY Id_reservation
                        OFFSET @PageSize * (@Page - 1) rows
                        FETCH NEXT @PageSize rows only";
            string queryCount = " SELECT COUNT(*) FROM reservation";
            IEnumerable<Reservation> reservationsTask = await _session.Connection.QueryAsync<Reservation>(stmt, pageRequest, _session.Transaction);
            int countTask = await _session.Connection.ExecuteScalarAsync<int>(queryCount, null, _session.Transaction);
            return new PageResponse<Reservation>(pageRequest.Page, pageRequest.PageSize, countTask, (reservationsTask).ToList());
        }

        public async Task<Reservation> GetAsync(int id)
        {
            //Evité l'injection sql avec des reqêtes paramétrées
            var stmt = @"select * from reservation where id_reservation = @id";
            return await _session.Connection.QueryFirstOrDefaultAsync<Reservation>(stmt, new { Id = id },  _session.Transaction);
        }

        public async Task<Reservation> InsertAsync(Reservation entity)
        {
            var stmt = @"insert into reservation(Nom, Prenom, Date, Telephone, Quantite,Id_menu, Id_formule) output INSERTED.id_reservation
            values (@Nom, @Prenom, @Date, @Telephone, @Quantite, @Id_menu, @Id_formule)";
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, entity, _session.Transaction);
            return await GetAsync(i);
        }

        public Task UpdateAsync(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public async Task <IEnumerable<Reservation>> GetAllAsync()
        {
            var stmt = @"select * from reservation";
            return await _session.Connection.QueryAsync<Reservation>(stmt, null, _session.Transaction);
        }
    }
}
