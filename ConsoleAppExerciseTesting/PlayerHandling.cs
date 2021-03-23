using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExerciseTesting
{
    [TestFixture]
    public class PlayerHandling
    {
        [Test]
        public void TestOne()
        {
            foreach (var Player in Program.Playerlist())
            {
                Assert.IsNotNull(Player.PlayerId);
                Assert.IsNotNull(Player.PlayerName);
                Assert.IsNotNull(Player.PlayerTeam);

            }
        }
    }
}
        
