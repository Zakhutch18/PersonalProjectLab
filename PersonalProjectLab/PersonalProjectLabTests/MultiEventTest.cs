using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;

namespace PersonalProjectLabTests
{
    [TestClass]
    public class MultiEventTest
    {
        [TestMethod]
        public void DEvent1ScoreTest()
        {
            MultiEventScore stats = new MultiEventScore();
            double DEvent1Score = stats.CalculatePoints100m(10.10);
            Assert.AreEqual(1072, DEvent1Score);
        }
        [TestMethod]
        public void DEvent2ScoreTest()
        {
            MultiEventScore stats = new MultiEventScore();
            double DEvent2Score = stats.CalculatePointsLJ(4.5);
            Assert.AreEqual(291, DEvent2Score);
        }
        [TestMethod]
        public void DEvent3ScoreTest()
        {
            MultiEventScore stats = new MultiEventScore();
            double DEvent3Score = stats.CalculatePointsSP(10.45);
            Assert.AreEqual(513, DEvent3Score);
        }
        [TestMethod]
        public void DEvent4ScoreTest()
        {
            MultiEventScore stats = new MultiEventScore();
            double DEvent4Score = stats.CalculatePointsHJ(2.34);
            Assert.AreEqual(1131, DEvent4Score);
        }
        [TestMethod]
        public void DEvent5ScoreTest()
        {
            MultiEventScore stats = new MultiEventScore();
            double DEvent5Score = stats.CalculatePoints400m(45.67);
            Assert.AreEqual(1026, DEvent5Score);
        }
        [TestMethod]
        public void DEvent6ScoreTest()
        {
            MultiEventScore stats = new MultiEventScore();
            double DEvent6Score = stats.CalculatePoints110HH(15.10);
            Assert.AreEqual(838, DEvent6Score);
        }
        [TestMethod]
        public void DEvent7ScoreTest()
        {
            MultiEventScore stats = new MultiEventScore();
            double DEvent7Score = stats.CalculatePointsDisc(50.86);
            Assert.AreEqual(889, DEvent7Score);
        }
        [TestMethod]
        public void DEvent8ScoreTest()
        {
            MultiEventScore stats = new MultiEventScore();
            double DEvent8Score = stats.CalculatePointsPV(5.03);
            Assert.AreEqual(920, DEvent8Score);
        }
        [TestMethod]
        public void DEvent9ScoreTest()
        {
            MultiEventScore stats = new MultiEventScore();
            double DEvent9Score = stats.CalculatePointsJavelin(98.48);
            Assert.AreEqual(1331, DEvent9Score);
        }
        [TestMethod]
        public void DEvent10ScoreTest()
        {
            MultiEventScore stats = new MultiEventScore();
            double DEvent10Score = stats.CalculatePoints1500m(240);
            Assert.AreEqual(954, DEvent10Score);
        }
        [TestMethod]
        public void DecathlonScoreTest()
        {
            MultiEventScore stats = new MultiEventScore();
            double DecathlonScore = stats.CalculatePointsDecathlon(1072,291,513,1131,1026,838,889,920,1331,954);
            Assert.AreEqual(8965, DecathlonScore);
        }
        [TestMethod]
        public void HEvent1ScoreTest()
        {
            MultiEventScore stats = new MultiEventScore();
            double HEvent1Score = stats.CalculatePoints100H(13.62);
            Assert.AreEqual(1033, HEvent1Score);
        }
        [TestMethod]
        public void HEvent2ScoreTest()
        {
            MultiEventScore stats = new MultiEventScore();
            double HEvent2Score = stats.CalculatePointsHJHept(1.98);
            Assert.AreEqual(1211, HEvent2Score);
        }
        [TestMethod]
        public void HEvent3ScoreTest()
        {
            MultiEventScore stats = new MultiEventScore();
            double HEvent3Score = stats.CalculatePointsSPHept(15.25);
            Assert.AreEqual(878, HEvent3Score);
        }
        [TestMethod]
        public void HEvent4ScoreTest()
        {
            MultiEventScore stats = new MultiEventScore();
            double HEvent4Score = stats.CalculatePoints200mHept(28.46);
            Assert.AreEqual(596, HEvent4Score);
        }
        [TestMethod]
        public void HEvent5ScoreTest()
        {
            MultiEventScore stats = new MultiEventScore();
            double HEvent5Score = stats.CalculatePointsLJHept(5.56);
            Assert.AreEqual(718, HEvent5Score);
        }
        [TestMethod]
        public void HEvent6ScoreTest()
        {
            MultiEventScore stats = new MultiEventScore();
            double HEvent6Score = stats.CalculatePointsJavelinHept(84.52);
            Assert.AreEqual(1538, HEvent6Score);
        }
        [TestMethod]
        public void HEvent7ScoreTest()
        {
            MultiEventScore stats = new MultiEventScore();
            double HEvent7Score = stats.CalculatePoints800mHept(120);
            Assert.AreEqual(1117, HEvent7Score);
        }
        [TestMethod]
        public void HeptathlonScoreTest()
        {
            MultiEventScore stats = new MultiEventScore();
            double Heptathlon1Score = stats.CalculatePointsHeptathlon(1033,1211,878,596,718,1538,1117);
            Assert.AreEqual(7091, Heptathlon1Score);
        }
    }
}
