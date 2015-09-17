using DogVDog.Web.Domains;
using DogVDog.Web.Models.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogVDog.Web.Services.Interfaces
{
    public interface IBreedService
    {
        void InsertBreed(BreedRequestModel model);

        List<Dog> GetAll();
    }
}
