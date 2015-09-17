using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogVDog.Web.Domains
{
    public class Dog
    {
        public string Breed { get; set; }

        public string Region { get; set; }

        public bool IsCute { get; set; }

        public string MedicalIssues { get; set; }
    }
}