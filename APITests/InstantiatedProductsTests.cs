using System.Collections.Generic;
using System.Linq;
using Xunit;
using DataAccessManager;

namespace APITests
{
    public class InstantiatedProductsTests
    {
        [Fact]
        public void CheckListAdditionOneItem()
        {
            // test product list addition (1 item) is working
            List<InstantiatedProducts> apps = new List<InstantiatedProducts>();
            apps.Add(new InstantiatedProducts("Product Test", 100, 29));

            var counts = apps.Count();

            Assert.True(counts == 1);
        }

        [Fact]
        public void CheckListAdditionMultipleItem()
        {
            // test product list addition (multiple items) is working
            List<InstantiatedProducts> apps = new List<InstantiatedProducts>();
            apps.Add(new InstantiatedProducts("Product Test", 100, 29));
            apps.Add(new InstantiatedProducts("Product Test", 100, 29));
            apps.Add(new InstantiatedProducts("Product Test", 100, 29));
            apps.Add(new InstantiatedProducts("Product Test", 100, 29));
            apps.Add(new InstantiatedProducts("Product Test", 100, 29));
            apps.Add(new InstantiatedProducts("Product Test", 100, 29));

            var counts = apps.Count();

            Assert.True(counts == 6);
        }
    }
}
