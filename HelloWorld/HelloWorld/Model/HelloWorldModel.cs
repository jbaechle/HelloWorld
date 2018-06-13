/// <summary>
/// Simple model containing text "Hello World" - In a more complex application you can replace this with a framework such as Entity framework.
/// </summary>
namespace HelloWorld.Model
{
    public class HelloWorldModel
    {
        private string helloText;
        public string HelloText { get => helloText; set => helloText = value; }
    }
}
