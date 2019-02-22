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
			 string result4= a.Prefix("hel yo are");
            Assert.AreEqual("10,3:hel yo are",result4);
			 string result5= a.Prefix("h e l l o ");
            Assert.AreEqual("10,5:h e l l o ",result5);
			 string result6= a.Prefix("hello how you ");
            Assert.AreEqual("14,3:hello how you ",result6);
			

        }
    }
}