using iMessengerCoreAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace WebAPISampleProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RGDialogsClientsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Guid> Get([FromQuery] Guid[] ClientIDs)
        {
            if (ClientIDs.Length == 0)
            {
                base.Response.StatusCode = (int)HttpStatusCode.NoContent;
                return null;
            }

            var dialogsGroupedByID = new RGDialogsClients().Init().GroupBy(x => x.IDRGDialog);

            var dialogsContainingAllClients = dialogsGroupedByID.Where(x => !ClientIDs.Except(x.Select(y => y.IDClient))
                                                                                      .Any())
                                                                .Select(x => x.Key);
            if (dialogsContainingAllClients.Count() == 0)
            {
                return new Guid[] { Guid.Empty };
            }

            return dialogsContainingAllClients;
        }
    }
}
