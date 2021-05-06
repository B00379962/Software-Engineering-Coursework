using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DataAccessManager;
using AssetReservation;

namespace APITests
{
    public class InstantiatedProductsTests
    {
        [Fact]
        public void CheckListAdditionOneItem()
        {
            List<InstantiatedProducts> apps = new List<InstantiatedProducts>();
            apps.Add(new InstantiatedProducts("Product Test", 100, 29));

            var counts = apps.Count();

            Assert.True(counts == 1);
        }

        [Fact]
        public void CheckListAdditionMultipleItem()
        {
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
