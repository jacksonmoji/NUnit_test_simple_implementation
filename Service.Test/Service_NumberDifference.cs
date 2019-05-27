using NUnit.Framework;
using Service.MainService;

namespace Tests
{
    [TestFixture]
    public class Service_NumberDifference
    {
        private MainService _numberService;

        public Service_NumberDifference()
        {
            _numberService = new MainService();
            _numberService.UserInput = 2;// change the test outcomes here, to make all test cases pass i will need to incorporate a for loop and supply the correct values accordinly :)
        }

        [Test]
        public void CheckTheSuppliedNumber1()
        {   
            var result = _numberService.numberDif();
            StringAssert.AreEqualIgnoringCase( "The number required to get to 5 is 4", result );
        }
        [Test]
        public void CheckTheSuppliedNumber2()
        {   
            var result = _numberService.numberDif();
            StringAssert.AreEqualIgnoringCase( "The number required to get to 5 is 3", result );
        }
        [Test]
        public void CheckTheSuppliedNumber3()
        {   
            var result = _numberService.numberDif();
            StringAssert.AreEqualIgnoringCase( "The number required to get to 5 is 2", result );
        }
        [Test]
        public void CheckTheSuppliedNumber4()
        {   
            var result = _numberService.numberDif();
            StringAssert.AreEqualIgnoringCase( "The number required to get to 5 is 1", result );
        }
        [Test]
        public void CheckTheSuppliedNumber5()
        {   
            var result = _numberService.numberDif();
            StringAssert.AreEqualIgnoringCase( "The number required to get to 5 is 0", result );
        }
    }
}