﻿using DotNetTests.Model;
using FluentAssertions;

namespace DotNetTests.Tests
{
    public class BmiCalculatorFacadeTests
    {
        private const string OVERWEIGHT_SUMMARY = "You are a bit overweight";

        [Fact]
        public void GetResult_ForValidInputs_ReturnsCorrectResult()
        {
            // arrange

            BmiCalculatorFacade bmiCalculatorFacade = new BmiCalculatorFacade(UnitSystem.Metric);

            double weight = 90;
            double height = 190;

            // act

            BmiResult result = bmiCalculatorFacade.GetResult(weight, height);

            // assert

            //Assert.Equal(24.93, result.Bmi);
            //Assert.Equal(BmiClassification.Overweight, result.BmiClassification);
            //Assert.Equal(OVERWEIGHT_SUMMARY, result.Summary);

            result.Bmi.Should().Be(24.93);
            result.BmiClassification.Should().Be(BmiClassification.Overweight);
            result.Summary.Should().Be(OVERWEIGHT_SUMMARY);
        }
    }
}