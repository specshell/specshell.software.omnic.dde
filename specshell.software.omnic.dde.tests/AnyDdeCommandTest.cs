using Specshell.Omnic.Dde.Commands;
using Xunit;

namespace Specshell.Omnic.Dde.Tests
{
    public class AnyDdeCommandTest
    {
        [Fact]
        public void CommandTypeExecuteTest()
        {
            var cmd = new AnyDdeCommand("[test]");
            Assert.Equal(CommandType.Execute, cmd.Type);
        }

        [Fact]
        public void CommandTypeExecuteOverrideTest()
        {
            var cmd = new AnyDdeCommand("[test]") { Type = CommandType.Request };
            Assert.Equal(CommandType.Request, cmd.Type);
        }

        [Fact]
        public void CommandTypePokeTest()
        {
            var cmd = new AnyDdeCommand("test", "test");
            Assert.Equal(CommandType.Poke, cmd.Type);
        }

        [Fact]
        public void CommandTypeRequestTest()
        {
            var cmd = new AnyDdeCommand("test");
            Assert.Equal(CommandType.Request, cmd.Type);
        }
    }
}
