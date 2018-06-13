using System;

using HelloWorld.Model;
using HelloWorld.Repository;

namespace HelloWorld
{
    /// <summary>
    /// Repository to write to console application - add other impementations later
    /// </summary>
    public class SimpleRepository : IRepository
    {
        public HelloWorldModel GetMessage()
        {
            return new HelloWorldModel { HelloText = "Hello World!" };
        }

        public string WriteMessage()
        {
            return "Successfully written";
        }
    }
}
