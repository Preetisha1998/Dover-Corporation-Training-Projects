using System.Collections.Generic;
using NUnit.Framework;
using Phase4Assesment.Models;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Test1()
        {
            PizzaBO context = new PizzaBO();
            int expectedValue = 12;
            List<PizzaModel> pizzas = context.GetItems();
            int actualValue = 0;
            foreach (var p in pizzas)
                actualValue++;
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void Test2()
        {
            PizzaBO context = new PizzaBO();
            string expectedValue="Mexican green wave";
            var pizza = context.GetItemById(2);
            var actualValue = pizza.PName;
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void Test3()
        {
            PizzaBO context = new PizzaBO();
            string expectedValue = "Deluxe  Veggie";
            string actualValue = context.GetItemByName(3);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}