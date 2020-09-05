/*
 * Copyright (c) 2020 Markus Neifer. All rights reserved.
 */
namespace MnCons.Samples.Linq
{
    using System.Linq;
    using Xunit;

    public class MyTests
    {
        [Fact]
        [Trait("Category", "MySamples")]
        public void MySamplesTest()
        {
            string[] fileLines = FileHelper.LoadFileLines("TestFiles\\customers.csv");
            char[] charsToTrim = { '"' };
            var customerLines = (from line in fileLines
                                 where line.StartsWith($"\"{customer.ExternalShopId}")
                                 let data = line.Split(',')
                                 select new Customer
                                 {
                                     Id = "00000000-0000-0000-0000-000000000000",
                                     ExternalShopId = data[0].Trim(charsToTrim),
                                     CountryCode = data[1].Trim(charsToTrim),
                                     Title = data[2].Trim(charsToTrim),
                                     FirstName = data[3].Trim(charsToTrim),
                                     LastName = data[4].Trim(charsToTrim),
                                     Email = data[5].Trim(charsToTrim),
                                     MobilePhone = data[31].Trim(charsToTrim),
                                     CultureCode = $"{data[8].Trim(charsToTrim)}-{data[1].Trim(charsToTrim)}",
                                     TaxCode = data[35].Trim(charsToTrim),
                                     ShippingAddress = new Address
                                     {
                                         Title = data[22].Trim(charsToTrim),
                                         FirstName = data[23].Trim(charsToTrim),
                                         LastName = data[24].Trim(charsToTrim),
                                         PhoneNumber = data[30].Trim(charsToTrim),
                                     }
                                 }).ToList();

            customerLines.Should().NotBeEmpty();
        }

        private string[] LoadFileLines(string filePath)
        {
            Uri codeBaseUrl = new Uri(Assembly.GetExecutingAssembly().CodeBase);
            string codeBasePath = Uri.UnescapeDataString(codeBaseUrl.AbsolutePath);
            string dirPath = Path.GetDirectoryName(codeBasePath);
            // ReSharper disable once AssignNullToNotNullAttribute
            return File.ReadAllLines(Path.Combine(dirPath, filePath), System.Text.Encoding.UTF8);
        }
    }
}
