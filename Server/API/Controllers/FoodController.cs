using API.BDD;
using API.BO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/plats")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class FoodController : ControllerBase
    {
        private readonly IBDDEmulation _bDDEmulation;
        public FoodController(IBDDEmulation bdd)
        {
            _bDDEmulation = bdd;
        }

        /// <summary>
        /// Permet de récupérer la liste des livres
        /// </summary>
        /// <returns>La liste des livres</returns>
        [HttpGet]
        public async Task<ActionResult<List<Plat>>> GetAll()
        {
            //Renvoi la liste de tous les livres
            return await Task.FromResult(Ok(_bDDEmulation.GetPlats()));
        }

        /// <summary>
        /// Permert de récupérer un livre avec son identifiant unique
        /// </summary>
        /// <param name="nom">Identifiant unique du livre</param>
        /// <returns>Renvoi le livre définit par l'identifiant unique</returns>
        [HttpGet("{nom}")]
        public async Task<ActionResult<Plat>> GetByName([FromRoute]string nom)
        {
            //Simulation de recherche BDD
            Plat plat = _bDDEmulation.GetPlats().Find((b) => b.Nom == nom);
            //END Simulation

            if(plat != null)
            {
                //Renvoi le livre avec un code 200
                return await Task.FromResult(Ok(plat));
            }else
            {
                //Renvoi un code 404 not found
                return await Task.FromResult(NotFound());
            }
        }

        /// <summary>
        /// Créer un livre et l'ajoute en BDD
        /// </summary>
        /// <param name="plat">Livre à ajouter sans l'identifiant unique</param>
        /// <returns>Renvoi le livre avec l'identifiant généré</returns>
        [HttpPost]
        public async Task<ActionResult<Plat>> CreatePlat([FromBody] Plat plat)
        {
            if(plat.Nom != null)
            {
                return await Task.FromResult(BadRequest());
            }
            else
            {
                //int? lastId = 0;
                //if(_bDDEmulation.GetPlats().Count > 0)
                //{
                //    lastId = _bDDEmulation.GetPlats()[_bDDEmulation.GetPlats().Count - 1 ].Nom  + 1;
                //}

                //book.BookId = lastId;

                //_bDDEmulation.GetBooks().Add(book);

                //return await Task.FromResult(Ok(book));
            }
        }

        [HttpDelete("{nom}")]
        public async Task<IActionResult> DeleteBook([FromRoute]string nom)
        {
            List<Plat> books = _bDDEmulation.GetPlats();

            int numberDelete = books.RemoveAll( b => b.BookId == id);

            if(numberDelete == 0)
            {
                 //Renvoi un code 404 not found
                return await Task.FromResult(NotFound());
            }
            else
            {
                //Renvoi un code 404 not found
                return await Task.FromResult(NoContent());
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Book>> ModifyBook([FromRoute] int id, [FromBody] Book book) 
        {
            // Si le livre envoyé est nul ou la route ne correspond pas au livre => BAD RESQUEST erreur 400
            if(book == null || book.BookId != id)
            {
                return await Task.FromResult(BadRequest());
            }

            //Simulation de recherche BDD
            Book bookInBDD = _bDDEmulation.GetBooks().Find((b) => b.BookId == id);
            //END Simulation

            if(bookInBDD != null)
            {
                // Modification du livre
                bookInBDD.Title = book.Title;
                bookInBDD.ISBN = book.ISBN;
                bookInBDD.Description = book.Description;

                //Renvoi du livre modifié au client
                return await Task.FromResult(Ok(bookInBDD));

            }
            else
            {
                //Renvoi un code 404 not found
                return await Task.FromResult(NotFound());
            }
        }
    }
}
