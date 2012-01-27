using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Myrkat.Tests.Opinions
{
    public class TestsController<CONTROLLER> : IDisposable
        where CONTROLLER : System.Web.Mvc.Controller, new()
    {
        protected CONTROLLER _controller = null;

        public TestsController() {
            Setup();
        }

        public void Dispose()
        {
            TearDown();
        }

        
        private void Setup()
        {
            _controller = new CONTROLLER();
        }

        private void TearDown()
        {
            _controller.Dispose();
            _controller = null;
        }
    }
}
