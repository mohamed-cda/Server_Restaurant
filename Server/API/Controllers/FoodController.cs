using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using BLL.Services;
using Microsoft.AspNetCore.Http;

using API.BusinessObject;
using BO.DTO.Responses;
using BO.DTO.Requests;

namespace API.Controllers
{
    [ApiController]
    [Route("api/Reservation")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class FoodController : ControllerBase
    {

        //Service qui gère la librairi
        private readonly IReservationService _reservationService = null;

        public FoodController(IReservationService restaurantService)
        {
            _reservationService = restaurantService;
        }


        /// <summary>
        /// Permet de récupérer la liste des livres
        /// </summary>
        /// <returns>La liste des livres</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<PageResponse<Reservation>>> GetAll([FromQuery] PageRequest pageRequest)
        {

            //return Ok(await _reservationService.GetAllReservations());
           return Ok(await _reservationService.GetAllReservations(pageRequest));
        }

        /// <summary>
        /// Permert de récupérer un livre avec son identifiant unique
        /// </summary>
        /// <param name="id">Identifiant unique du livre</param>
        /// <returns>Renvoi le livre définit par l'identifiant unique</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetReservationById([FromRoute] int id)
        {
            Reservation reservation = await _reservationService.GetReservationById(id);
            if (reservation == null)
            {
                return NotFound(); // StatusCode = 404
            }
            else
            {
                return Ok(reservation); // StatusCode = 200
            }
        }


        /// <summary>
        /// Créer un livre et l'ajoute en BDD
        /// </summary>
        /// <param name="reservation">Livre à ajouter sans l'identifiant unique</param>
        /// <returns>Renvoi le livre avec l'identifiant généré</returns>
        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateReservation([FromBody] Reservation reservation)
        {
            // Ajout du livre avec la bll server
            Reservation newReservation = await _reservationService.CreateReservation(reservation);
            if (newReservation != null)
            {
                // Créer une redirection vers GetBookById(newBook.BookId);
                return CreatedAtAction(nameof(GetReservationById), new { id = newReservation.Id_reservation }, newReservation);
            }
            else
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteReservation([FromRoute] int id)
        {
            if (await _reservationService.RemoveReservationById(id))
            {
                // Renvoie un code 204 aucun contenu
                return NoContent();
            }
            else
            {
                // Renvoie un code 404: la ressource est introuvable
                return NotFound();
            }
        }


        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ModifyReservation([FromRoute] int id, [FromBody] Reservation reservation)
        {
            if (reservation == null || id != reservation.Id_reservation)
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
            else
            {
                Reservation reservationModified = await _reservationService.ModifyReservation(reservation);
                if (reservationModified != null)
                {
                    // Renvoie la ressource modifiée
                    return Ok(reservationModified);
                }
                else
                {
                    // Renvoie un code 404: la ressource est introuvable
                    return NotFound();
                }
            }
        }

    }
}

