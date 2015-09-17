using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DogVDog.Web.Models.RequestModels
{
    public class BreedRequestModel
    {
        [Required]
        public string Breed { get; set; }

        public string Region { get; set; }

        public bool IsCute { get; set; }

        public string MedicalIssues { get; set; }

    }
}