using System;
using System.Collections.Generic;
using System.Text;

namespace FeefoTechnical.models
{
    public class Normaliser
    {
        private IEnumerable<string> _normalisedJobTitles;

        public Normaliser()
        {
            _normalisedJobTitles = new List<string>
            {
                "Architect",
                "Software engineer",
                "Quantity surveyor",
                "Accountant",
            };
        }
        public string Normalise(string jobTitle)
        {
         

            return "";
        }
    }
}
