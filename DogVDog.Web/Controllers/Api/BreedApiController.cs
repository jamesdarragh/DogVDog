using DogVDog.Web.Models.RequestModels;
using DogVDog.Web.Services;
using DogVDog.Web.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DogVDog.Web.Services.Interfaces;

namespace DogVDog.Web.Controllers.Api
{
    [RoutePrefix("api/breed")]
    public class BreedApiController : ApiController
    {
        //private IBreedService _breedService;

        //public BreedApiController(IBreedService BreedService)
        //{
        //    _breedService = BreedService;
        //}

        [Route(""), HttpPost]
        public HttpResponseMessage InsertBreed(BreedRequestModel model)
        {
            if (ModelState.IsValid)
            {
                BreedService.InsertBreed(model);

                return Request.CreateResponse(HttpStatusCode.OK, model);
            }
            else
                return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
            
        }
        [Route(""), HttpGet]
        public HttpResponseMessage GetAllBreeds()
        {
            List<Dog> result = BreedService.GetAll();

            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}
