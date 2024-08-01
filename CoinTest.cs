using MyCoins.Models;

namespace MyCoins.Test
{
    public class CoinTest
    {
        private static Random random = new Random();
        private static IEnumerable<Coin> MockCoins()
        {
            yield return new Coin { Id = 1, Country = "Italy", Year = 1973, Metal = "Aluminum",
                Face = "/images/img1.jpg", Denomination = "5 lire" };
            yield return new Coin { Id = 2, Country = "Italy", Year = 1980, Metal = "Aluminum",
                Face = "/images/img2.jpg", Denomination = "10 lire" };
            yield return new Coin { Id = 3, Country = "Italy", Year = 1967, Metal = "Steel",
                Face = "/images/img3.jpg", Denomination = "50 lire" };
            yield return new Coin { Id = 4, Country = "Italy", Year = 1975, Metal = "Steel",
                Face = "/images/img4.jpg", Denomination = "100 lire" };
            yield return new Coin { Id = 5, Country = "Italy", Year = 1978, Metal = "Bronze",
                Face = "/images/img5.jpg", Denomination = "200 lire" };
            yield return new Coin { Id=6, Country="Italy", Year=1965, Metal="Silver",
            Face="/images/img6.jpg", Denomination="500 lire" };
        }

        [Fact]
        public void ChangeYearInRange()
        {
            //Arrange
            foreach(var coin in MockCoins())
            {
                //Act
                coin.Year += random.Next(-20, 20);

                //Assert
                Assert.InRange(coin.Year, 1900, 2023);
            }
        }

        [Fact]
        public void CountryPropertyContainsRussia()
        {
            //Arrange
            List<string> countryNames = new();
            foreach (var coin in MockCoins())
            {
                countryNames.Add(coin.Country);
            }
            Assert.Contains("Italy", countryNames);
        }
    }
}