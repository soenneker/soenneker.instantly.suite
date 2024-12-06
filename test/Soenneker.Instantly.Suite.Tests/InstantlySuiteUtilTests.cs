using Soenneker.Tests.FixturedUnit;
using Xunit;
using Xunit.Abstractions;

namespace Soenneker.Instantly.Suite.Tests;

[Collection("Collection")]
public class InstantlySuiteUtilTests : FixturedUnitTest
{
    public InstantlySuiteUtilTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }
}
