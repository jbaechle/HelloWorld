using System;

using HelloWorld.Model;
using HelloWorld.Repository;

namespace HelloWorld
{
    public class ConsoleRepository : IRepository
    {
        HelloWorldModel model = new HelloWorldModel();

        public void Write()
        {
            Console.WriteLine(model.ModelText);
            Console.Read();
        }
    }
}
