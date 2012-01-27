using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xunit;
using Xunit.Extensions;
using FluentAssertions;
using FluentAssertions.Assertions;
using FluentAssertions.Common;
using Myrkat.Controllers;
using Myrkat.Tests.Opinions;

using System.Web.Mvc;

namespace Myrkat.Tests.WebSiteTests.Controllers
{
    public class HomeControllerTests : TestsController<HomeController>
    {
        [Fact]
        public void index_action_should_be_viewresult()
        {
            var result = _controller.Index();

            result.Should().BeOfType<ViewResult>();
        }

        [Fact]
        public void index_action_should_render_index_view()
        {
            var result = _controller.Index() as ViewResult;

            result.ViewName.Should().BeEquivalentTo("Index");
        }
    }
}
