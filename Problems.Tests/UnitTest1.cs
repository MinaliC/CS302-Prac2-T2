using NUnit.Framework;
using Problems;

namespace Tests
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
            Program a= new Program();
            string result1= a.Prefix("hello");
            Assert.AreEqual("5,1:hello",result1);
             string result2= a.Prefix("");
            Assert.AreEqual("0,0:",result2);
             string result3= a.Prefix("what ... did you say?? ");
            Assert.AreEqual("23,5:what ... did you say?? ",result3);

        }
    }
}