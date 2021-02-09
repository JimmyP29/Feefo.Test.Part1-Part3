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

        [Fact(DisplayName = "GIVEN an empty string, " +
                            "WHEN passed into the Normaliser" +
                            "THEN an empty string is returned.")]
        public void Normalise_EmptyStringPassedIn_ReturnsEmptyString()
        {
            var result = _normaliser.Normalise("");
            Assert.Equal("", result);
        }

        [Fact(DisplayName = "GIVEN un-normalised job title 'Java engineer', " +
                            "WHEN passed into the Normaliser" +
                            "THEN normalised job title 'Software engineer' is returned.")]
        public void Normalise_UnnormalisedJobTitleJavaEngineerPassedIn_ReturnsNormalisedJobTitle()
        {
            var result = _normaliser.Normalise("Java engineer");
            Assert.Equal("Software engineer", result);
        }

        [Fact(DisplayName = "GIVEN un-normalised job title 'C# engineer', " +
                            "WHEN passed into the Normaliser" +
                            "THEN normalised job title 'Software engineer' is returned.")]
        public void Normalise_UnnormalisedJobTitleCSharpEngineerPassedIn_ReturnsNormalisedJobTitle()
        {
            var result = _normaliser.Normalise("C# engineer");
            Assert.Equal("Software engineer", result);
        }

        [Fact(DisplayName = "GIVEN un-normalised job title 'Accountant', " +
                            "WHEN passed into the Normaliser" +
                            "THEN normalised job title 'Accountant' is returned.")]
        public void Normalise_UnnormalisedJobTitleAccountantPassedIn_ReturnsNormalisedJobTitle()
        {
            var result = _normaliser.Normalise("Accountant");
            Assert.Equal("Accountant", result);
        }

        [Fact(DisplayName = "GIVEN un-normalised job title 'Chief Accountant', " +
                            "WHEN passed into the Normaliser" +
                            "THEN normalised job title 'Accountant' is returned.")]
        public void Normalise_UnnormalisedJobTitleChiefAccountantPassedIn_ReturnsNormalisedJobTitle()
        {
            var result = _normaliser.Normalise("Chief Accountant");
            Assert.Equal("Accountant", result);
        }

        [Fact(DisplayName = "GIVEN un-normalised job title 'Surveyor', " +
                            "WHEN passed into the Normaliser" +
                            "THEN normalised job title 'Quantity surveyor' is returned.")]
        public void Normalise_UnnormalisedJobTitleSurveyorPassedIn_ReturnsNormalisedJobTitle()
        {
            var result = _normaliser.Normalise("Surveyor");
            Assert.Equal("Quantity surveyor", result);
        }

        [Fact(DisplayName = "GIVEN un-normalised job title 'Junior Architect', " +
                            "WHEN passed into the Normaliser" +
                            "THEN normalised job title 'Architect' is returned.")]
        public void Normalise_UnnormalisedJobTitleJuniorAcritectPassedIn_ReturnsNormalisedJobTitle()
        {
            var result = _normaliser.Normalise("Architect");
            Assert.Equal("Architect", result);
        }
    }
}