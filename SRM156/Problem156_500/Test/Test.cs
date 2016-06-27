using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Problem156_500;

namespace Test
{
    [TestFixture]
    public class Test
    {
        private BombSweeper m_BombSweeper;
        [SetUp]
        public void Initial()
        {
            m_BombSweeper = new BombSweeper();
        }

        [Test]
        public void Test1()
        {
            var value = m_BombSweeper.winPercentage(new string[]
            {
                ".....",
                ".....",
                "..B..",
                ".....",
                "....."
            });

            Assert.AreEqual(value, 94.11764705882354);
        }

        [Test]
        public void Test2()
        {
            var value = m_BombSweeper.winPercentage(new string[]
            {
                "BBBBB",
                "B...B",
                "B...B",
                "B...B",
                "BBBBB"
            });

            Assert.AreEqual(value, 5.882352941176471);
        }

        [Test]
        public void Test3()
        {
            var value = m_BombSweeper.winPercentage(new string[]
            {
                ".........",
                ".B..B..B.",
                ".........",
                ".........",
                ".B..B..B.",
                ".........",
                ".........",
                ".B..B..B.",
                "........."
            });

            Assert.AreEqual(value, 0.0);
        }

        [Test]
        public void Test4()
        {
            var value = m_BombSweeper.winPercentage(new string[]
            {".........................",
 ".........................",
 ".........................",
 "........................."});

            Assert.AreEqual(value, 100.0);
        }

        [Test]
        public void Test5()
        {
            var value = m_BombSweeper.winPercentage(new string[]
            {
                "......B.......B..B...........................B....",
                "..............B..................BB..B............",
                "B.B.B.............B.....B..............B..........",
                "...................B...B....................BB....",
                "...B.....B.........................B.......B.....B",
                "B.B.........B.....B.......B..B......B.B...B.BB....",
                "..B...................BB...............B..........",
                ".........B...B................B..B................",
                ".......BB.......B....B................B.....BBB...",
                ".......BB..........B..............B......BB.......",
                "...................BB.....................B.......",
                "...B.B.B......B..............B...B......B.........",
                "B................B................................",
                "....B..........B.....B..BB....B...............BB..",
                "..B....B.....B.............B.....B............B...",
                "...................B.B........B..B.........B.B....",
                ".....B.....B......................................",
                "...........BB......BB...B.B........B...B..........",
                ".....BBB..........................................",
                ".B...........B....B...BB......B......B...B.B......",
                "..................B........BB................B....",
                "...............................B..B....BBB.B....B.",
                "..........B.......................................",
                ".....B..........B....BB......B.B......B......B....",
                ".....B..................B........B................",
                "............B.....B..B....BB...B....BB........B...",
                "..B.................B.........B...................",
                ".BB..............B................................",
                "...B....B..................B.................B....",
                "......B...B......B......................B.B.......",
                "..............B..................B.......B........",
                ".....B........BB...B.....B........................",
                ".......B......B.B..B..........B...........B....B..",
                "B...B...........B...B...B......B.B...B..B......B..",
                "....B..B.....B.B.......BB..B............B.B....B..",
                "B.......B..........B.........B...B.BB......B......",
                "....B...............................B.............",
                ".....B.B..........................................",
                "..........B............B......B.B..B....B.........",
                "....B...B.......................B.................",
                "B.................B...........B..B....B...........",
                "...B.....B........................................",
                "...B..B......................................BBB..",
                ".B...B....................................B....B..",
                "...B...B..........B...B.B.........................",
                ".....B.............B...BB..........B..BBB.BB......",
                "....................B.....B.......................",
                "........B..BB..........B.B....B...........B......B",
                ".........B.....BB..B.............B....BB..........",
                "....B..B..............B...B..B..........B........."
            });

            Assert.AreEqual(value, 77.67558528428094);
        }

        [Test]
        public void Test6()
        {
            var value = m_BombSweeper.winPercentage(new string[]
            {"."});

            Assert.AreEqual(value, 100.0);
        }

        [Test]
        public void Test7()
        {
            var value = m_BombSweeper.winPercentage(new string[]
            {"B"});

            Assert.AreEqual(value, 0.0);
        }

        [Test]
        public void Test8()
        {
            var value = m_BombSweeper.winPercentage(new string[]
            {"B."});

            Assert.AreEqual(value, 0.0);
        }

        [Test]
        public void Test9()
        {
            var value = m_BombSweeper.winPercentage(new string[]
            {"B."});

            Assert.AreEqual(value, 0.0);
        }


        [Test]
        public void Test10()
        {
            var value = m_BombSweeper.winPercentage(new string[]
            {
                "B.................................................", "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                "..................................................",
                ".................................................."
            });

            Assert.AreEqual(value, 99.9599519423308);
        }

        [Test]
        public void Test11()
        {
            var value = m_BombSweeper.winPercentage(new string[]
            {"..BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "..BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB"});

            Assert.AreEqual(value, 0.040048057669203045);
        }

        [Test]
        public void Test12()
        {
            var value = m_BombSweeper.winPercentage(new string[]
             {"..B...B.BB.B..B...B.......B.........B.B..B...", ".......B...B..B...B..B.B..B.B..B.......B.....", "...B.B..B.B.B.B.....B.....B...B......BBB.....", ".B....B....B..........B.BB.....B.BB....B..B.B", "B...BB..BBBB....B....B..B.B....B.....BB......", "B.....BBB.B.B...BB.B.B....B..B.B.B....B.B.BB.", "B...B.BB......B....B........B.B.B.BB.B....B..", "...B......B...B...B.BB...B....B..B....BBB....", ".........BB.....BB..B.BB.B..BBBB...B.....B..B", "..BBBB......BBB...BB............B.BB...B.B...", "...B...BB..B...B.....B.B..B..B...B.......B...", "...B..B....B...B.....B..BB.B....B..B....B....", ".B.....B......B.B...B.......BBB.B.....B.BBB..", "........B....B.B....B.B.BB.......B....B...B..", ".B............B.BBBB.B..BB.BB....B.........B.", "...B......B....B.......BB.B.B.B..............", "B.B............BB......B.B..B.........BBB..B.", "..BB...B....B...B..B........B.....B.B..B.....", "..B...BB......B.B.B....B....B.BB...B.....B...", "...BB......B............B...BB..B.B.....B..B.", "...B.B....BBB.....B...BB...B....BB.B.......B.", "B.B.B...BB.B.B...B..BBB........B......B..B...", "B..BBBBB..B..B......B.......B...B............", "....B..B.....B.B..B..B..B..B.B.......B.B.....", "B.....B.B.....BB................BB....B..B.B.", "....BB.BBB.B.B.B..........B.B..B..B..B..B....", "..B.BB.......B.....B..B....B..B..BB.B...B..BB", "......B..BB..B...B........B.B..B..B...BBB...B", ".....B.....BBB......B...........B.B.BB......B", "....B.....B...B.B.B.B.B.....B...B.B.B...BB...", ".B.B....BBB....................B......B..B...", "..B..BB.BBBBB..B.BBBB..BB........BBB.BB......", "B...B..B....B.................B.B........B.B.", ".....B..........B....B......BBB.B....B..BB..B", "B.B.BB.B.B....BB............B.....BBB.B.....B", "B...B......B...B..B..B.B...B...B.....B.......", "......BB......B.B...B......BB......B.B..B.B.B", "BB..B........B.......BB.B................BBBB", "BB......B.B.....B.B..........BB......B..B....", "B...B..B..BB.BB.B......B.B.B.B...BB...B...B..", "B...BBB.BB.B......BB..B.BB.............B....B"});

            Assert.AreEqual(value, 18.12191103789127);
        }
        [Test]
        public void Test13()
        {
            var value = m_BombSweeper.winPercentage(new string[]
            {"BBBB.B.BB..B....BB.B.BB..B.B....B..B"});

            Assert.AreEqual(value, 19.047619047619047);
        }
        [Test]
        public void Test14()
        {
            var value = m_BombSweeper.winPercentage(new string[]
            {".B.BB.....B.B..B..B..B..B..B.BB.....B.B.B..B.BB.B"});

            Assert.AreEqual(value, 24.0);
        }

        [Test]
        public void Test15()
        {
            var value = m_BombSweeper.winPercentage(new string[]
             {"BBBBB.BBBB...BBBBB.B.BBBB.BB", "B..BBBB.BBB.BBB.B..B.B.BB.BB"});

            Assert.AreEqual(value, 0.0);
        }

        [Test]
        public void Test16()
        {
            var value = m_BombSweeper.winPercentage(new string[]
             {"..B..B..B..B...B.", "....BBB.........."});

            Assert.AreEqual(value, 33.333333333333336);
        }

        [Test]
        public void Test17()
        {
            var value = m_BombSweeper.winPercentage(new string[]
             {"B", "B", "B", "B", "B", ".", "B", "B", ".", ".", "B", ".", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "B", "."});

            Assert.AreEqual(value, 0.0);
        }

        [Test]
        public void Test18()
        {
            var value = m_BombSweeper.winPercentage(new string[]
             {"B", "B", "B", ".", ".", "B", ".", "B", ".", "B", ".", ".", ".", "B", "B", "B", ".", ".", ".", "B", ".", ".", ".", "B", ".", "B", ".", "B", ".", ".", ".", "B", ".", ".", ".", "B", "B", ".", "B", ".", ".", "."});

            Assert.AreEqual(value, 29.166666666666668);
        }

        [Test]
        public void Test19()
        {
            var value = m_BombSweeper.winPercentage(new string[]
             {"..", "B.", "BB", "..", "BB", "..", ".B", "B.", ".B", "BB", "..", ".B", ".B", ".B", ".B", "BB", "..", "B.", "BB", ".B", "BB", "BB", "..", ".B", "BB"});

            Assert.AreEqual(value, 0.0);
        }

        [Test]
        public void Test20()
        {
            var value = m_BombSweeper.winPercentage(new string[]
             {"BB", "BB", ".B", "B.", "BB", "..", "..", "BB", "B.", ".B", "BB", "BB", "B.", "B.", "..", "B.", "B.", ".B", "BB", "..", "..", "BB", ".B", ".B", "BB", "..", "BB", ".B", "B.", "B.", ".B", "BB", ".B", "BB", "..", "..", "B.", "BB", ".B", ".B", ".B", "B.", "BB", "BB"});

            Assert.AreEqual(value, 0.0);
        }

        [Test]
        public void Test21()
        {
            var value = m_BombSweeper.winPercentage(new string[]
            {"B.......B..B...B.B.....B.B.B...B.......BB.", "BB...........BBBB........B...BBBBB........", "..B.B..B..B.B.B...............B.BB.B.B.B.B", ".......B..B..B......B....B....B...B..B...B", "BBBBB..B..BB..B...B..B.B......B......BB.B.", "B......B.BB..B....B..B......B.........B..B", "......B...B........BB...B.BB.......BB..BBB", "..B..B..BB.BB..B.....B..............B..BB.", ".B...B..B...BB.....B.....BB.........B.B...", "...B......B..B.B......BBB...B.B.....B.B.B.", "...B..........BB..B.B..........B.....B.BB.", "BB.B..B..B..B...B...B....B...BBB.....BB..B", "....B.....B...BBB..B......BBBB.......B....", "....B..B.B......B..B..BBBB...B....BB....B.", ".BB..BBBB.B...B....B....B.B..B.B...BB..B..", ".B........B.B..B.....BBB.B.BB.BBB...B.....", "....BB.......BB.....B.........B....B.BB...", "....BB......B....BB.........B.B....B.B.B..", "BB.BBBBBBBB........B......B..B..BB........", "B......BBB.BBB......B..B......B...........", "...B......BB.B..B..BBBB..B..B....BB....B..", "B....BBB.....B...B........BBB..BB.B...BB..", "....B...B..B.B....B...BB.B..BB..BB...B...B", "..B....B..............B.............B.....", "BBBB...B...........B...BB..B..........B.B.", ".........B.B.B.B.B..........B...B....B.BB.", ".BB..B.....B......B....BB....B.BB...B.B..B", "B...B..B.BB..B...B.B....B..BB..BB.BBB.B.B.", ".....BBBB.......B.......B..B......BB......", "B........B...B.B..BB...B...B..B.B......B..", ".....BBB....B..B.B..B..B....BB.B..B...BB..", "...BBBBB...B.B..B...BB..B......BBBB..B.B..", "...B...B.....BBBB.......B.B...B...BBB.BBB.", "....BB..B.B.B.B..BB......BB..B..........B.", ".B..B......B...B.BB..BB..B.BB.........BBB.", "........B..B...B...BBB...B.......B..B..B..", "..BB.B......B...BB...B..BB......B.B..B.B.B"});

            Assert.AreEqual(value, 17.36745886654479);
        }

        [Test]
        public void Test22()
        {
            var value = m_BombSweeper.winPercentage(new string[]
            {
                "BBBBBBB..BBBBBBBBBBBBB..BBBBB.BB.B.BBBBBBBBBB", ".BBBB.B.B.BBBBBBBBBBBBB.BB.BBBBBBBBBBBBBBBB.B",
                "BBBBBBBB.BBBBB....B.BBBBBBBBBBBBBBBBBB.BBBB.B", "BBBBBB.BBB.BBBB.BBBB.BBB.BBB.BBBBBBBBBBBBBB..",
                "BBBBBBBBBBBBB.BBBBBBB.BBBBBBBBBBB.BBBBB.BBBBB", "BBBBB...BB.BBBB.BB.BBBBBBBB.BBBBBB.BBBBB..BBB",
                "BBBBBBBBBBBB.BBBBBBBBBBBBBBB...B.B...BBBBBB.B", ".B..B..BBBBBBBBB.BB.BBBBB.BBBB.BBBB..BBBBBBBB",
                ".B.BBBB..B.BBBBBBBBB.BB.BB.B.B.BBB.BBBB.BBB.B", ".BB.B..BBBBBBBBBBBBBB.BBBBBBBBBBBB.BBB.B.BBBB",
                "BBBBBBB..BBB..BBBBBBB.BB.BBBB.BBB.BBBBBBB.B..", "BBBBBBBBBBBBBBBBB.BBBB.B.BB.BB..BBB.BB.BBB...",
                "..BBBBBBBBBB.BBB.BBBBBB.BBB.BBBB.B.BBBBBBBBBB", ".BBBBBBBBB.B..BBBB.BB.B.BBBB..BB.BBB..BBBBBBB",
                ".BBB..BBBB.BBBBBBBBB.BBBBBBBBBBBBBBBBB.BB.BBB", "BB.B.BBBBBB.B..BBB.BB.BB.BB.BBBBBB.B..BBBBBBB",
                "BBBB.BBBBBB.BBBB.BBBBBBBBB..BBBB.B.B..B.BBBBB", "BBB.BBB.BB.B...BBBBBBBBBB.BBBBBBB.BB.BB.BBBBB",
                "BBBBBBBBBBBBBBB.BBBBBBBBBB.BBBBBBBBBBBBBBBBB.", ".B.BBBB.BBBB.BBBB.B.B.BBBBBB.BBBBBBBBBBBB.B.B",
                "B.BBBBBBBBBB.BBBBBBB.BBBBBBBBBB.BBBBBBB.BB..B", "BBBBBBBBB.BBBB.B..BBBB.BBBBBBBBBBBBBBB..BB...",
                "BBBBBBBBBB.BBBBBBBBB.B.BBBBB.BBBBBB.B.BBBBBBB", "BBBBBBB.BBBBB.B.BBBBBBB.BBBB.BBBBBBBBB.B.BB.B",
                "BBB..BBBBBBBBBB.BBB.B.B.BBBB.B.BBBB.BBB.BBBBB", ".B.BBB.BBBBBBB..B.BBBB.BBBBBBBBBBBBBBBB.BBBB.",
                "..BBBB.BBBBBBBB.B.BBBB.B...BB.BB.BBB.B.BBBBBB", "BBB.B.BB..BBBB.BBBBBBBBBBB..BB.B.BBBBBBBBBBBB",
                "BB..BBB.BBBBBBBBBBBBBBBB.BBBB.BBBBBBBB.BBB.BB", "BBBBBBBBB.BBBBBBBBBBB..BBBBBBBBB..BBBBBB..BB.",
                "B.BBBB.BB.BBB.BBBB.BBBBB.B.BBBB.B.BBBBBBBBBB.", "B.BBBB...B.B.BB...BBBBB.B.BBBBB.BBBBBBBBB..BB",
                "BBBBBBBBBBBB.BB.B.BB.BBBBBBBBBB.B..BBBBBB.BBB", "BBBBBBBBBB..BBBB..B.BBBBBBBBBBBB.BBBBBBBBB.BB",
                "B...B.BBBBB.BBBBBBBBBBBB.BB.BBB.BBBBBBBBBBBBB", "BBBBBB.BB.BBBBBBBBBBBBBBBBBBBBBBBBBBB.BB..BBB",
                "B.BBBBBBBBBB..BBBBBBBBBB.BBBB.BB...BB...BB.BB", "BBBBBBBBBBBBBBBBBB.B..BBBBBBBBBBBBBBBBBBBBB.B",
                "BBBB.BBBB..BB.BB.BB.BBBB.BB.B.BBB.B.BB.BBBB.B", ".BB.BBBB.BBBBB.B.BBBB.BBB.BBBBBB.BB.BB.BBB.BB",
                ".BBB.BBB..BBB.B.BBBBBB.BBB.B.B.BB.BBBBBBBB.BB", "BB.B..BBBBBBBBBB..BBB..BBBBB.B.BBB.BB.BB.BB.B"
            });

            Assert.AreEqual(value, 0.0);
        }

        [Test]
        public void Test23()
        {
            var value = m_BombSweeper.winPercentage(new string[]
            {".B..........B.B....BB..B.BBB...B.BB...BB...B", "...B...B.BB....BB..B.B.B.B...B..B.....BBB..B", ".BB.BBB.BB...BB.B.BBB.B.B......B.B..........", "B..B.B.B.BB...B.BB.....B.B.B................", "B..BB..BB.......B.B......B.....B...........B", "B...B..B.B.B.B.B.B..B.BB.B...B.BB....B..BB.B", ".B.....B.BB...BB..B..B.B.BBB......B......B.B", ".BBB.B.B..BB...B.B..BB.BB.............BBBB.B", "...B........B.B.......B.......B....BB....B.B", ".B..BBBB...B..BB.....B..B..BB.B.....BB...B..", "B.B..B.B.B..B..B....BB.B..............B.....", ".B..BB..B..B.BB..B.......B.......B..BBBB...B", ".B..B......B.B...BBBB....B.B...BBBBB.......B", "B...BBB.....BBBBBB...B...B.....B.B..........", ".B.........B...B.B.BB.B.....BBBB.B..B....B..", ".B.BB.B.B..B....B.BBBB.B.BB..B.B......B...BB", "BB.....BB.....B..B....B...B..B.BB.....BBB.B.", "B.....B....BBBBBB......B..B....B.B.....BB.BB", "..BBB.BB.B.B.B.B..B....B.B..BBB...B.B..B....", "B.....B..B....BB..B...B.B...B.......B.....B.", ".BB..BB.BB..BB....B....BB.B.B.BB.....B....B.", "B............B.B.....B..BBBB.B....BBB..BBB.B", ".....B.....B...B..BB...BBBBBB..B.BB.........", ".....B..BBBB.B..BBB.B.B...B......B...BBB..BB", ".BB.B.BB.........B..B.B.BB.BB.....BBB..BB...", "...B.B.B....B.....B..B.........B.B..........", "..B.B..BBB...B...B..BBBB..B..BBB..B..B....B.", "B....B........BB.......B.B.....B..BB...B....", "B....B...B.B..B....BB.BB.B....BB...BBB...BB.", ".........BB....BB....B.BB....BBB.B.B..B..B..", ".B....BB...B....BB.BBBBB.B.....BB...B.B.B...", ".....BBB....B............B..B.......BB.B..B."});

            Assert.AreEqual(value, 9.578544061302683);
        }

        [Test]
        public void Test24()
        {
            var value = m_BombSweeper.winPercentage(new string[]
            {".BBBBB.B.BBBBBBBBB.B.BB.BBBB.B..BBBBB....B.BB.BBB", "BB.B.BB.BBB.BBBBBBB.BB.BBBBBBB.BBBBBBBBBBBBBB.BBB", "BBBBBB.BBBBB.BB.BBB.BBBBBBBBBBBBB.BB.B.BBB.BBB.BB", "BBBBB.BBBBBBBBBBBBBBBBBBBBBBB.BBBBBBB.BBBBB.B...B", "B.BBBBBBBBBB.BBBBBB.BBBBBBB.BBBBBBBBB..BBBBBBBBBB", "BBBBBBBBBBBBBBBBB.BBB..BB..BBBBBBBBBBBB.BBBB.BBBB", "BB.BBBBBBBBBBBBBBB.BBBBBBBBBBBBBBBBBBBB.BBBBBBBBB", "BB...BBBBBB.BBB.BBBBBBBBBBBBBBBBBBB.BBBBBB.BBB.BB", ".BBBBBBBBB.BBBBBB.BBBBBB.BBBBBBBBBBBBBBBB...BBBBB", "BBBBBBB.BBB.BBBBBB.BBB.BB.BBBBBBB.B.BB.BBBBBBBBBB", "BBBB.B.BBBB.BBB..BBBB..BBBBBBBBBBBBBBBBBBBBBBBBBB", "BBBBBBB.BB.BBBB.BBBBBB..BBBBBBBBBBBBB.BBBBBBB.BBB", "BBB.BBBBBBBBBBBBB.BBBBB.BB..BBBBBBBB.BBBBB.BBBBBB", ".B.BBBBBBB..BBBBBB.B.BBBBB..BBBBBBBBBBBBBBBBBBBB.", "BBBBBBB.B.BBBBBBBBBBBBBBBBBBBB.BB.BBBBB.BBBBBBBBB", ".BBBBBBBBBBBBB..BBBBBBBBB.BB.BBBBBBBBBBBBBBBBBB.B", "BBBBBBBBBBBB.B.BBB.B.BBBB.BBBB.BBBBBBBBBBBBB.BBBB", "BBBBBB...B.BBBBBBBBBBBBBBB.BBBBB.BBBBBBBBBB.B.BBB", "B.BBBBBBBBB.BB.BB.BBBBBBBB.BBBBBBB.BBB.BBBBBBBBBB", "BBBBBBBB.B.BBBBBBBBBBBB..B.BBBBBBBBBBB.BBBBB.B..B", "BBBBBB.BBBB.BB.BBBBBBB.BBBB.BBBBBBBB.BBBBBBBBBBBB", "BB.BB.BBBBBBBBBBB.BBBBBBB.BBBBBBBBBBBBBBBBBBBB.BB", "..BBB.B.BBBBBBBBBBBBBBBBBBBBBBBB..BBBB.B.B.BBB.B.", "BBBBBBBBBBBBB.BBBB.BBB.B.BBBBBBBBBBBBBB..BBBBBBBB", ".BBB.BBBBBBBBBBBBB.BBBBB.BBB.BBBB.BBB.BBBBBBBB..B", "BB.BB.BBB.BBBBBB.BBBBBBB..BBBBBB..B.BBBBBBBBBBBB.", "BB.BBB.BBBBBBB.BBBB.BBBBBBBBBBBBBBBBBBBBBBBBB.BBB", "B.BBBB.BBBBBB..BBBBBBB.BBBBBBBBBBBB..B.B.BB.B.BBB", ".B.BBBBBBBBBBBBBBBBBBBB.BBBBBBBBBBBBBBBBBBBBBB.BB", "BB.BBBBBBBBBBBBBBBB.BBBBBBBB.BBBBBBBB..BBBBBBBBBB", "BB.BBBBBBBBBBBBBB.BBBBBBBBBBBBBBBB.B.B.BBB..B.BB.", ".BB.BB..B.BBBBBBBBBBBB.BBBBB.B..BB..BBBBBB.BB.BBB", "BBBB..BBBBBBBBB..BBBBBBBBBBBBBB.BB.BBBBBBBBBBBBBB", "BBBBB.BBBBBBBBBBBBBBBBBBBBBB..BBBBB.BBB.B.BBBBBBB", "BB.BBBBBBB.B..BBBBBBBBBBBBBBB.BBB.BBBBBBBBB.BBBBB", "BBBBBBB.BB.BBBB..BBBBBBBBBBBBBBBBBBBBBB.BBBBBBB.B", "BBB.BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB..BBB.B.", "BBBBBBBB.BBBBBBBBBBBBB..BBBBBBBB.BBBBBBBBBBBBBBBB", "BBBBBBBBBBBB.BB.BB..BBBBBBBBBBBBBBB.BBBBB.BBB.BBB", "BBBBBBBBBBBBBBBBBBBBB.BBBBBBBBBBBBBBBBBBBBB.BBB..", "..B.BBBBBBBBB.BB.BBBBB..BBBBBB.BBBBBBBBBBBBBBB.BB", "BBBBB..BBB.BBB.BB.BBBBBBBB.B.BBBBBBB.BBBBBB.BBBBB", "BBBBBBBB..BBBBBBBBBBBBBBBB.BBBB..BBBBBBBBBB.BBBB.", "BBBBBBBBB.BBBBBBBBBBBBBBBB.BBBBB.BBBBB.BBB..B.BBB", "BBBBBBBBBBBBBBBBB.BBB.BBBBBBBBBBB.BBB.BBBBBBBBBBB"});

            Assert.AreEqual(value, 0.0);
        }

        [Test]
        public void Test26()
        {
            var value = m_BombSweeper.winPercentage(new string[]
             {"B..", "...", "..B"});

            Assert.AreEqual(value, 50.0);
        }

        [Test]
        public void Test27()
        {
            var value = m_BombSweeper.winPercentage(new string[]
              {".....", ".....", "..B..", ".....", "....."});

            Assert.AreEqual(value, 94.11764705882354);
        }

        [Test]
        public void Test28()
        {
            var value = m_BombSweeper.winPercentage(new string[]
             {".........", ".B..B..B.", ".........", ".........", ".B..B..B.", ".........", ".........", ".B..B..B.", "........."});

            Assert.AreEqual(value, 0.0);
        }

        [Test]
        public void Test29()
        {
            var value = m_BombSweeper.winPercentage(new string[]
             {"......B.......B..B...........................B....", "..............B..................BB..B............", "B.B.B.............B.....B..............B..........", "...................B...B....................BB....", "...B.....B.........................B.......B.....B", "B.B.........B.....B.......B..B......B.B...B.BB....", "..B...................BB...............B..........", ".........B...B................B..B................", ".......BB.......B....B................B.....BBB...", ".......BB..........B..............B......BB.......", "...................BB.....................B.......", "...B.B.B......B..............B...B......B.........", "B................B................................", "....B..........B.....B..BB....B...............BB..", "..B....B.....B.............B.....B............B...", "...................B.B........B..B.........B.B....", ".....B.....B......................................", "...........BB......BB...B.B........B...B..........", ".....BBB..........................................", ".B...........B....B...BB......B......B...B.B......", "..................B........BB................B....", "...............................B..B....BBB.B....B.", "..........B.......................................", ".....B..........B....BB......B.B......B......B....", ".....B..................B........B................", "............B.....B..B....BB...B....BB........B...", "..B.................B.........B...................", ".BB..............B................................", "...B....B..................B.................B....", "......B...B......B......................B.B.......", "..............B..................B.......B........", ".....B........BB...B.....B........................", ".......B......B.B..B..........B...........B....B..", "B...B...........B...B...B......B.B...B..B......B..", "....B..B.....B.B.......BB..B............B.B....B..", "B.......B..........B.........B...B.BB......B......", "....B...............................B.............", ".....B.B..........................................", "..........B............B......B.B..B....B.........", "....B...B.......................B.................", "B.................B...........B..B....B...........", "...B.....B........................................", "...B..B......................................BBB..", ".B...B....................................B....B..", "...B...B..........B...B.B.........................", ".....B.............B...BB..........B..BBB.BB......", "....................B.....B.......................", "........B..BB..........B.B....B...........B......B", ".........B.....BB..B.............B....BB..........", "....B..B..............B...B..B..........B........."});

            Assert.AreEqual(value, 77.67558528428094);
        }


        [Test]
        public void Test30()
        {
            var value = m_BombSweeper.winPercentage(new string[]
             {".BBBBBBBBBBBBB"});

            Assert.AreEqual(value, 0.0);
        }


        [Test]
        public void Test31()
        {
            var value = m_BombSweeper.winPercentage(new string[]
             {".......BB"});

            Assert.AreEqual(value, 75.0);
        }
    }
}
