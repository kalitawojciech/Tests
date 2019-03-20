using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1.Test.Unit
{
    class BaseTests
    {
        [Test]
        public void Green_test()
        {
            Assert.Pass(); 
        }

        [Test]
        public void Red_test()
        {
            Assert.Fail();
        }

        [Test]
        public void Inconclisive_test()
        {
            Assert.Inconclusive();
        }

        [Test]
        public void Collection_Test()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };

            CollectionAssert.Contains(numbers, 2);
            CollectionAssert.DoesNotContain(numbers, 10);  //sprawdza czy numbers nie zawiera 10

            Assert.That(numbers, Has.Member(4));  // sprawdza czy numbers zawiera 4
            Assert.That(numbers, Is.Unique);   // sprawdza czy wartości w numbers są unikalne
        }

        [Test]
        [SetCulture("pl-PL")]
        public void polish_locale_date_test()
        {
            string date = new DateTime(1940, 4, 28).ToString("d MMMM yyyy");
            Assert.That(date, Is.EqualTo("28 kwietnia 1940"));
        }
    }
}
