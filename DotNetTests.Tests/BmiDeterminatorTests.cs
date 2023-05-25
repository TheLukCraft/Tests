using DotNetTests.Model;

namespace DotNetTests.Tests
{
    public class BmiDeterminatorTests
    {
        //[Fact]
        //public void DetermineBmi_ForBmiBelow18_5_ReturnsUnderweightClassification()
        //{
        //    // arrange

        //    BmiDeterminator bmiDeterminator = new BmiDeterminator();
        //    double bmi = 10;

        //    // act

        //    BmiClassification result = bmiDeterminator.DetermineBmi(bmi);

        //    // assert

        //    Assert.Equal(BmiClassification.Underweight, result);
        //}
        [Theory]
        [InlineData(10.0)]
        [InlineData(13.0)]
        [InlineData(15.0)]
        public void DetermineBmi_ForBmiBelow18_5_ReturnsUnderweightClassification(double bmi)
        {
            // arrange

            BmiDeterminator bmiDeterminator = new BmiDeterminator();

            // act

            BmiClassification result = bmiDeterminator.DetermineBmi(bmi);

            // assert

            Assert.Equal(BmiClassification.Underweight, result);
        }

        [Theory]
        [InlineData(10.0, BmiClassification.Underweight)]
        [InlineData(13.0, BmiClassification.Underweight)]
        [InlineData(15.0, BmiClassification.Underweight)]
        [InlineData(19.0, BmiClassification.Normal)]
        [InlineData(21.0, BmiClassification.Normal)]
        [InlineData(24.0, BmiClassification.Normal)]
        [InlineData(25.0, BmiClassification.Overweight)]
        [InlineData(26.0, BmiClassification.Overweight)]
        [InlineData(28.8, BmiClassification.Overweight)]
        [InlineData(30.9, BmiClassification.Obesity)]
        [InlineData(31.0, BmiClassification.Obesity)]
        [InlineData(32.8, BmiClassification.Obesity)]
        [InlineData(36.5, BmiClassification.ExtremeObesity)]
        [InlineData(37.2, BmiClassification.ExtremeObesity)]
        [InlineData(39.2, BmiClassification.ExtremeObesity)]
        public void DetermineBmi_ForGivenBmi_ReturnsCorrectClassification(double bmi, BmiClassification classification)
        {
            // arrange

            BmiDeterminator bmiDeterminator = new BmiDeterminator();

            // act

            BmiClassification result = bmiDeterminator.DetermineBmi(bmi);

            // assert

            Assert.Equal(classification, result);
        }
    }
}