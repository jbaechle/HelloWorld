using System;
using System.Configuration;

using HelloWorld.Service;
using HelloWorld.Repository;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // where we read hello world string - can change this to multiple sources later
                IRepository repository = new SimpleRepository();

                // service api we are using to write
                IHelloWorldService service;

                // read the WriteLocation from App.config to determine WriteLocation
                string writeLocation = ConfigurationManager.AppSettings["WriteLocation"];

                // where are we writting to
                switch (writeLocation)
                {
                    case "Console":
                        {
                            service = new HelloWorldConsoleService(repository);
                            break;
                        }
                    default: // default to ConsoleService - TODO add other location later
                        {
                            service = new HelloWorldConsoleService(repository);
                            break;
                        }
                }

                string message = service.Write();

                if (message == string.Empty)
                {
                    //TODO: Error Logging
                }
            }
            catch (Exception)
            {
                //TODO: Error Logging
            }

            // prevent console from closing
            Console.Read();
        }
    }
}
