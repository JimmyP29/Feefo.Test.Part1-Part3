using System;
using System.Collections.Generic;
using System.Text;

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
          //  var accumulator = 0;
            var highScore = 0;
            var jCharacter = "";
            var jtCharacter = "";
            var result = "";
            var lastCharMatched = false;

            foreach (string job in _normalisedJobTitles)
            {
                foreach (char j in job)
                {
                    foreach (char jt in jobTitle)
                    {
                        if (j.ToString().ToLower() == jt.ToString().ToLower())
                        {
                            quality++;

                            if (!(jCharacter == "" && jtCharacter == ""))
                                if (jCharacter.ToLower() == jtCharacter.ToLower())
                                {
                                    quality++;
                                    lastCharMatched = true;
                                }
                                else 
                                {
                                    lastCharMatched = false;
                                }
                                    
                          
                            jCharacter = j.ToString();
                            jtCharacter = jt.ToString();
                            

                            //if (quality > accumulator)
                            //    accumulator = quality;

                            //if (accumulator > highScore)
                            //    highScore = accumulator;
                        }

                        if (!lastCharMatched)
                        {
                            jtCharacter = "";
                            jCharacter = "";
                        }
                        
                        // jtCharacter = "";
                    }
                    //jCharacter = "";
                }

               
                //accumulator = 0;

                if (quality > highScore)
                {
                    result = job;
                    highScore = quality;
                }
                    

                quality = 0;
            }
            //foreach (var job in _normalisedJobTitles)
            //{
            //    for (int i = 0; i < job.Length - 1; i++)
            //    {
            //        for (int k = 0; k < jobTitle.Length; k++)
            //        {
            //            if (jobTitle[k] == job[i])
            //            {
            //               // character = job[i].ToString();
            //                quality++;

            //                if (quality > highScore)
            //                    highScore = quality;

            //            }
            //            continue;
            //        }
            //    }

            //    if (highScore > 0)
            //        result = job;

            //    quality = 0;
            //}



            return result;
        }
    }
}
