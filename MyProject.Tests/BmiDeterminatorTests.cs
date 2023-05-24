namespace MyProject.Tests
{
    public class BmiDeterminatorTests
    {
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
    }
}