using System;
using System.Collections.Generic;
using System.Text;

using HelloWorld.Model;

namespace HelloWorld.Repository
{
    public interface IRepository
    {
        HelloWorldModel GetMessage();
        string WriteMessage();
    }
}
