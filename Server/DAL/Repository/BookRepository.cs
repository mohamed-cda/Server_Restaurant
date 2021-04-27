using BO.Entity;
using DAL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Logging;
using BO.DTO.Responses;
using BO.DTO.Requests;

namespace DAL.Repository
{
    class BookRepository : IBookRepository
    {
        private readonly DbSession _session;
        private readonly ILogger<BookRepository> _logger;
        public BookRepository(DbSession dbSession, ILogger<BookRepository> logger)
        {
            _session = dbSession;
            _logger = logger;
        }

        public Task<int> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            var stmt = @"select * from book";

            return await _session.Connection.QueryAsync<Book>(stmt, null, _session.Transaction);
        }

        public async Task<PageResponse<Book>> GetAllAsync(PageRequest pageRequest)
        {
            var stmt = @"select * from book 
                        ORDER BY Id
                        OFFSET @PageSize * (@Page - 1) rows
                        FETCH NEXT @PageSize rows only";
            string queryCount = " SELECT COUNT(*) FROM book";

            IEnumerable<Book> booksTask = await _session.Connection.QueryAsync<Book>(stmt, pageRequest, _session.Transaction);
            int countTask = await _session.Connection.ExecuteScalarAsync<int>(queryCount, null, _session.Transaction);


            return new PageResponse<Book>(pageRequest.Page, pageRequest.PageSize, countTask, (booksTask).ToList());
        }

        public async Task<Book> GetAsync(int id)
        {
            //Evité l'injection sql avec des reqêtes paramétrées
            var stmt = @"select * from book where id = @id";
            return await _session.Connection.QueryFirstOrDefaultAsync<Book>(stmt, new { Id = id },  _session.Transaction);
        }

        public async Task<Book> InsertAsync(Book entity)
        {
            var stmt = @"insert into book(ISBN, title, description) output INSERTED.ID
            values (@iSBN, @title, @description)";
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, entity, _session.Transaction);
            return await GetAsync(i);
        }

        public Task UpdateAsync(Book entity)
        {
            throw new NotImplementedException();
        }
    }
}
