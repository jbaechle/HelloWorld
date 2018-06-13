using Microsoft.VisualStudio.TestTools.UnitTesting;

using HelloWorld.Model;
using HelloWorld.Repository;
using HelloWorld.Service;


namespace HelloWorld.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Test_HelloWorld_Service_API()
        {
            //Commented out, can use Moq framework in future for test so tests do not write to database or console text file ect.
            /*var repository = new Mock<IRepository>();
           repository.Setup(mock => mock.GetMessage()).Returns("Hello World!");*/

           IRepository repository = new SimpleRepository();
           IHelloWorldService service = new HelloWorldConsoleService(repository);
           Assert.Equals(service.Write(), "Successfully written");
        }
    }
}
