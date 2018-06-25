using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiCrecheRepository.Models.Repositories;
using WebApiCrecheRepository.Models;


namespace WebApiCrecheRepository.Controllers
{
    public class CrecheController : ApiController
    {
        private CrecheRepository repository = null;

        public CrecheController()
        {
            this.repository = new CrecheRepository();
        }

        public CrecheController(CrecheRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet] // Get all records API/Creche
        public IHttpActionResult Get()
        {
            List<Creche> creches = (List<Creche>)repository.SelectAll();
            if (creches != null)
            {
                return Ok(creches);
            }
            else
            {
                return NotFound();
            }
        } // end Get all

        [HttpGet] // Get a single specified record API/Creche/id
        public IHttpActionResult Get(int id)
        {
            Creche creche = repository.SelectByID(id);
            if (creche != null)
            {
                return Ok(creche);
            }
            else
            {
                return NotFound();
            }
        } // end Get single

        [HttpPost]// POST API/Creche
        public IHttpActionResult Create([FromBody]Creche obj)
        {
            try
            {
                if (ModelState.IsValid)
                { // check valid state
                    repository.Insert(obj);
                    repository.Save();
                    return Ok(obj);
                }
                else // not valid request
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } // end POST Create

        [HttpPut]// PUT API/Creche
        public IHttpActionResult Update(int id, [FromBody]Creche obj)
        {
            try
            {
                Creche existing = repository.SelectByID(id);

                if (existing == null)
                {
                    return NotFound();
                }
                else
                {
                    existing.ChildAddress = obj.ChildAddress;
                    existing.ChildName = obj.ChildName;
                    existing.Email = obj.Email;
                    existing.EmergencyNumber = obj.EmergencyNumber;
                    existing.GuardianName = obj.GuardianName;
                    existing.MobileNumber = obj.MobileNumber;
                    existing.TelNumber = obj.TelNumber;
                }
                if (ModelState.IsValid)
                { // check valid state
                    repository.Update(existing);
                    repository.Save();
                    return Ok(existing);
                }
                else // not valid request
                {
                    return Content(HttpStatusCode.NotModified, obj);
                }
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        } // end PUT Update

        [HttpDelete]// DELETE API/Creche/id
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Creche existing = repository.SelectByID(id);
                if (existing == null)
                {
                    return NotFound();
                }
                repository.Delete(id);
                repository.Save();
                return Ok(existing);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        } // end DELETE Delete

    }
}
