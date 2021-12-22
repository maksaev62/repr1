using System;
using repr1.Domain;
using repr1.Repository;
using Microsoft.AspNetCore.Mvc;

namespace repr1.Controllers
{
    [ApiController]
    [Route("/autopicker")]
    public class AutopickerController : ControllerBase
    {
        [HttpPut]
        public Autopicker Create(Request autopicker)
        {
            Storage.AutopickerStorage.Create(autopicker);
            return autopicker;
        }

        [HttpGet]
        public Autopicker Read(int autopickerId)
        {
            return Storage.AutopickerStorage.Read(autopickerId);
        }

        [HttpPost]
        public Autopicker Update(int requestId, Autopicker newRequest)
        {
            return Storage.AutopickerStorage.Update(autopickerId, newAutopicker);
        }

        [HttpDelete]
        public bool Delete(int autopickerId)
        {
            return Storage.AutopickerStorage.Delete(autopickerId); ;
        }
    }
}
