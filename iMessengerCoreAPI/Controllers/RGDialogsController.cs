using iMessengerCoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using iMessengerCoreAPI.Utils;
namespace iMessengerCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RGDialogsController : ControllerBase
    {
        [HttpPost]
        public JsonResult getDialog(List<Guid> clients)
        {
            List<RGDialogsClients> dialogs = new RGDialogsClients().Init();
            List<RGDialogsClients> dialogsCLients = new List<RGDialogsClients>();
            foreach (var client in clients)
            {
                dialogsCLients.Add(dialogs.FirstOrDefault(x => Guid.Equals(x.IDClient, client)));
            }
            return new JsonResult(RGDialogsUtil.FindDialog(dialogsCLients));
        }
     
        
    }
}
