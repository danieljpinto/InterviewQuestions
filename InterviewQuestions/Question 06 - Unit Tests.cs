using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    /// <summary>
    /// Write a new unit test class (either inside this file, or in a new one) that will test the method below.
    /// The expectation is that 2 unit tests will be written.
    /// 
    /// No unit test frameworks have been added, so it is up to your preference whether to use Nunit, Xunit, MSTest, or any other testing frameworks.
    /// </summary>
    public class Question6
    {
        private IQuestion6Dependency _dependency;

        public Question6(IQuestion6Dependency dependency)
        {
            _dependency = dependency;
        }

        public string GetFirstSixCharactersOfDatabaseValue()
        {
            var dbValue = _dependency.GetValueFromDatabase();
            return dbValue.Substring(0, 6);
        }
    }

    public interface IQuestion6Dependency
    {
        string GetValueFromDatabase();
    }

    public class Question6Tests
    {
        private Question6 _subject;
        private Mock<IQuestion6Dependency> _dependency;
        private string _dbValue => "ThisStringHasOver6Digits";

        [SetUp]
        public void Setup()
        {
            _dependency = new Mock<IQuestion6Dependency>();
            _dependency.Setup(c => c.GetValueFromDatabase()).Returns(_dbValue);

            _subject = new Question6(_dependency.Object);
        }

        [Test]
        public void GetFirstSixCharactersOfDatabaseValue_GetsValueFromDatabase()
        {
            _subject.GetFirstSixCharactersOfDatabaseValue();

            _dependency.Verify(c => c.GetValueFromDatabase(), Times.Once);
        }

        [Test]
        public void GetFirstSixCharactersOfDatabaseValue_OnlyReturnsFirstSixDigits()
        {
            var expectedResult = _dbValue.Substring(0, 6);

            var ActualResult = _subject.GetFirstSixCharactersOfDatabaseValue();

            Assert.That(ActualResult, Is.EqualTo(expectedResult));
        }
    }
}
