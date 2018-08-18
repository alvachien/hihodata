using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AlvaChien.HIH.OData.Models;
using Microsoft.AspNet.OData;

namespace hihodata.Controllers
{
    [Produces("application/json")]
    [Route("api/DBVersion")]
    public class DBVersionController : ODataController
    {
        [EnableQuery(PageSize = 10, MaxExpansionDepth = 2)]
        public IActionResult Get()
        {
            return Ok(context.Customers);
        }

        public async Task<IActionResult> Post([FromBody] DBVersion nver)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //context.Customers.Add(entity);
            //await context.SaveChangesAsync();
            return Created(nver);
        }

        public async Task<IActionResult> Put([FromODataUri] int key, [FromBody] DBVersion nver)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else if (key != nver.VersionID)
            {
                return BadRequest("The key from the url must match the key of the entity in the body");
            }
            //var originalCustomer = await context.Customers.FindAsync(key);
            //if (originalCustomer == null)
            //{
            //    return NotFound();
            //}
            //else
            //{
            //    context.Entry(originalCustomer).CurrentValues.SetValues(entity);
            //    await context.SaveChangesAsync();
            //}
            return Updated(nver);
        }

        [AcceptVerbs("PATCH", "MERGE")]
        public async Task<IActionResult> Patch([FromODataUri] int key, Delta<DBVersion> nver)
        {
            //object id;
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            //else if (patch.GetChangedPropertyNames().Contains("Id") && patch.TryGetPropertyValue("Id", out id) && (int)id != key)
            //{
            //    return BadRequest("The key from the url must match the key of the entity in the body");
            //}
            //Customer originalEntity = await context.Customers.FindAsync(key);
            //if (originalEntity == null)
            //{
            //    return NotFound();
            //}
            //else
            //{
            //    patch.Patch(originalEntity);
            //    await context.SaveChangesAsync();
            //}
            //return Updated(originalEntity);

            return NoContent();
        }


        public async Task<IActionResult> Delete([FromODataUri]int key)
        {
            //Customer entity = await context.Customers.FindAsync(key);
            //if (entity == null)
            //{
            //    return NotFound();
            //}
            //else
            //{
            //    context.Customers.Remove(entity);
            //    await context.SaveChangesAsync();
            //    return NoContent();
            //}

            return NoContent();
        }
    }
}
