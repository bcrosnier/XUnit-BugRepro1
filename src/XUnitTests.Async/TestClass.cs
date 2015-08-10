using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTests.Async
{
    public class TestClass
    {
        [Fact]
        public async Task AsynchronousFactWithTaskReturn()
        {
            await Task.Delay( 100 );
        }

        [Fact]
        public async void AsynchronousFactWithVoidReturn()
        {
            await Task.Delay( 100 );
        }

        [Fact]
        public void SynchronousFact()
        {
            Task.Delay( 100 ).Wait();
        }
    }
}
