using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PortlandBusiness.Models;
using Microsoft.EntityFrameworkCore;

namespace PortlandBusiness.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BusinessesController : ControllerBase
  {
    private PortlandBusinessContext _db;

    public BusinessesController(PortlandBusinessContext db)
    {
      _db = db;
    }

    // GET api/businesses
    [HttpGet]
    public ActionResult<IEnumerable<Business>> Get()
    {
      return _db.Businesses.ToList();
    }

    // POST api/businesses
    [HttpPost]
    public void Post([FromBody] Business business)
    {
      _db.Businesses.Add(business);
      _db.SaveChanges();
    }

    // GET api/businesses/{id}
    [HttpGet("{id}")]
    public ActionResult<Business> Get(int id)
    {
      return _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
    }

    // PUT api/businesses/{id}
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Business business)
    {
      business.BusinessId = id;
      _db.Entry(business).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/businesses/{id}
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var businessToDelete = _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
      _db.Businesses.Remove(businessToDelete);
      _db.SaveChanges();
    }
  }
}