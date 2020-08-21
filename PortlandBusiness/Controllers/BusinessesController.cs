using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PortlandBusiness.Models;

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
  }
}