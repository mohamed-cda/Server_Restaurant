using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using DAL.Repository;
using DAL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    internal class LibrairiService : IRestaurantService
    {
        private readonly IUnitOfWork _db;

        public LibrairiService(IUnitOfWork unitOfWork)
        {
            _db = unitOfWork;
        }

        #region Books
        public async Task<Book> CreateBook(Book book)
        {
            _db.BeginTransaction();
            IBookRepository _books = _db.GetRepository<IBookRepository>();
            Book newBook = await _books.InsertAsync(book);
            await _books.InsertAsync(book);
            await _books.InsertAsync(book);
            _db.Commit();
            return newBook;
        
         }

        public async Task<Book> ModifyBook(Book book)
        {
            return await Task.FromResult(new Book());
        }

        public async Task<bool> RemoveBookById(int id)
        {
            return await Task.FromResult(true);
        }

        public async Task<PageResponse<Book>> GetAllBooks(PageRequest pageRequest)
        {
            IBookRepository _books = _db.GetRepository<IBookRepository>();

            return await _books.GetAllAsync(pageRequest);

        }

        public async Task<Book> GetBookById(int id)
        {
            
            IBookRepository _books = _db.GetRepository<IBookRepository>();

            return await _books.GetAsync(id);
        }

        #endregion
    }
}
