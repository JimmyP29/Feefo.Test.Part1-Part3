using System.Collections.Generic;

namespace FeefoTechnical.models
{
    public class Normaliser
    {
        private List<string> _normalisedJobTitles;

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
            var quality = 0;
            var highScore = 0;
            var jCharPreviousMatch = "";
            var jtCharPreviousMatch = "";
            var result = "";
            var lastCharMatched = false;

            foreach (string job in _normalisedJobTitles)
            {
                foreach (char j in job)
                {
                    foreach (char jt in jobTitle)
                    {
                        var jLower = j.ToString().ToLower();
                        var jtLower = jt.ToString().ToLower();

                        if (jLower == jtLower)
                        {
                            quality++;

                            if (!(jCharPreviousMatch == "" && jtCharPreviousMatch == ""))
                                if (jCharPreviousMatch == jtCharPreviousMatch)
                                {
                                    quality++;
                                    lastCharMatched = true;
                                }
                                else 
                                    lastCharMatched = false;
                                
                            jCharPreviousMatch = jLower;
                            jtCharPreviousMatch = jtLower;
                        }

                        if (!lastCharMatched)
                        {
                            jCharPreviousMatch = "";
                            jtCharPreviousMatch = "";
                        }
                    }
                }

                if (quality > highScore)
                {
                    result = job;
                    highScore = quality;
                }

                quality = 0;
            }

            return result;
        }
    }
}
