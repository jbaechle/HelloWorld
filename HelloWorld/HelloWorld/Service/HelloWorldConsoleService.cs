using System;

using HelloWorld.Model;
using HelloWorld.Repository;

namespace HelloWorld.Service
{
    /// <summary>
    /// Simple API Service
    /// </summary>
    class HelloWorldConsoleService : IHelloWorldService
    {
        private IRepository _repository;

        // pass in desired repository that implements IRepository
        public HelloWorldConsoleService(IRepository repository)
        {
            _repository = repository;
        }

        public string Write()
        {
            try
            {
                HelloWorldModel model = _repository.GetMessage();
                Console.WriteLine(model.HelloText);
            }
            catch(Exception)
            {
                // TODO: logging
                // return failure
                return string.Empty;
            }

            //return success
            return _repository.WriteMessage();
        }
    }
}
