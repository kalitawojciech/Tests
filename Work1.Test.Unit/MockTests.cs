using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace Work1.Test.Unit
{
    public class MockTests
    {
        [Test]
        public void test1()
        {
            //Arrange
            var customer = new CustomerMyMock(20);
            var validator = new IsCustomerAdultValidator();

            //Act
            var result = validator.Validate(customer);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void test2()
        {
            //Arrange
            var customerMock = new Mock<ICustomer>();
            customerMock.Setup(s => s.GetAge()).Returns(21);
            ICustomer customer = customerMock.Object;

            var validator = new IsCustomerAdultValidator();

            //Act
            var result = validator.Validate(customer);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void test3()
        {
            //Arrange
            var customer = Mock.Of<ICustomer>(s => s.GetAge() == 21);
            var validator = new IsCustomerAdultValidator();

            //Act
            var result = validator.Validate(customer);

            //Assert
            Assert.IsTrue(result);
        }
    }

    internal class CustomerMyMock : ICustomer
    {
        public CustomerMyMock()
        {
        }

        public CustomerMyMock(int age)
        {
            this.age = age;
        }
        public string FirstName {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public IPhoneNumber PhoneNumber {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public IList<IOrder> Orders {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public int age { get; set; }
        public int GetAge()
        {
            return age;
        }
    }
}
