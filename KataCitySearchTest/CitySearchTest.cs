using KataCitySearch;
using NUnit.Framework;
using System.Collections.Generic;

namespace KataCitySearchTest
{
    public class Tests
    {
        ICitySearch _sut;
        [SetUp]
        public void Setup()
        {
            _sut = new CitySearch();
            var emptyList = new List<string>();
        }
        
        [Test]
        public void TestFewerThan2Char()
        {
            var actual = _sut.SearchInCities("a");
            var expected = new List<string>();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMoreThan2Char()
        {
            var actual = _sut.SearchInCities("Va");
            var expected = new List<string> { "Valencia", "Vancouver" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMoreThan2CharLowerCase()
        {
            var actual = _sut.SearchInCities("va");
            var expected = new List<string> { "Valencia", "Vancouver" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestPartOfName()
        {
            var actual = _sut.SearchInCities("ape");
            var expected = new List<string> { "Budapest" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestStar()
        {
            var actual = _sut.SearchInCities("*");
            var expected = CitiesDB.Cities;
            Assert.AreEqual(expected, actual);
        }
    }
}