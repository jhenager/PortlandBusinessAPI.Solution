using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PortlandBusiness.Models;
using Microsoft.EntityFrameworkCore;

namespace PortlandBusiness.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RestaurantsController : ControllerBase
  {
    private PortlandBusinessContext _db;

    public RestaurantsController(PortlandBusinessContext db)
    {
      _db = db;
    }

    // GET api/restaurants
    [HttpGet]
    public ActionResult<IEnumerable<Restaurant>> Get()
    {
      return _db.Restaurants.ToList();
    }

    // POST api/restaurants
    [HttpPost]
    public void Post([FromBody] Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
    }

    // GET api/restaurants/{id}
    [HttpGet("{id}")]
    public ActionResult<Restaurant> Get(int id)
    {
      return _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
    }

    // PUT api/restaurants/{id}
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Restaurant restaurant)
    {
      restaurant.RestaurantId = id;
      _db.Entry(restaurant).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/restaurants/{id}
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var restaurantToDelete = _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
      _db.Restaurants.Remove(restaurantToDelete);
      _db.SaveChanges();
    }
  }
}