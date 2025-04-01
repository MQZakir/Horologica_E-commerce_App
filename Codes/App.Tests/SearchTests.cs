using SWE5201_AssingmentV3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Tests
{
    [TestFixture]
    public class SearchTests
    {
        [Test]
        public void SearchProducts_WithValidKeyword_ReturnsMatchingProducts()
        {
            // Arrange
            string keyword = "Breitling"; // Example keyword to search for
            List<ViewWatch> expectedWatches = new List<ViewWatch>
        {
            new ViewWatch { Brand = "Breitling", Model = "Navitimer B01 Chronograph 43", Price = "AED 37500", Image = "/bHome.png" },
        };

            // Act
            List<ViewWatch> result = DatabaseHelper.SearchProducts(keyword);

            // Assert
            Assert.AreEqual(expectedWatches.Count, result.Count);

            foreach (var expectedWatch in expectedWatches)
            {
                Assert.IsTrue(result.Any(w => w.Brand == expectedWatch.Brand && w.Model == expectedWatch.Model));
            }
        }

        [Test]
        public void SearchProducts_WithInvalidKeyword_ReturnsEmptyList()
        {
            // Arrange
            string keyword = "InvalidKeyword"; // Non-existent keyword

            // Act
            List<ViewWatch> result = DatabaseHelper.SearchProducts(keyword);

            // Assert
            Assert.IsEmpty(result);
        }
    }
}
