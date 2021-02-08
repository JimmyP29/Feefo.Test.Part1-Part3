using FeefoTechnical.models;
using Xunit;

namespace FeefoTechnical.UnitTests
{
    public class NormaliserTests
    {
        private readonly Normaliser _normaliser;

        public NormaliserTests()
        {
            _normaliser = new Normaliser();
        }

        [Fact(DisplayName ="GIVEN an un-normalised job title, " + 
                           "WHEN passed into the Normaliser" +
                           "THEN a normalised job title is returned.")]
        public void Normalise_UnnormalisedJobTitlePassedIn_ReturnsNormalisedJobTitle()
        {
            
        }
    }
}