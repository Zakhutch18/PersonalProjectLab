using System;
namespace PersonalProjectLab
{
    public class MultiEventScore
    {
        public MultiEventScore()
        {


        }
        public double CalculatePoints100m(double DEvent1)
        {
            double Points100m = 25.4347 * Math.Pow((18.00 - DEvent1), 1.81);
            Points100m = Math.Round(Points100m, 0, MidpointRounding.ToEven);
            return (Points100m);
        }
        public double CalculatePointsLJ(double DEvent2)
        {
            double ConversionLJ = DEvent2 * 100;
            double PointsLJ = .14354 * Math.Pow((ConversionLJ - 220), 1.4);
            PointsLJ = Math.Round(PointsLJ, 0, MidpointRounding.ToEven);
            return (PointsLJ);
        }
        public double CalculatePointsSP(double DEvent3)
        {
            double PointsSP = 51.39 * Math.Pow((DEvent3 - 1.50), 1.05);
            PointsSP = Math.Round(PointsSP, 0, MidpointRounding.ToEven);
            return (PointsSP);
        }
        public double CalculatePointsHJ(double DEvent4)
        {
            double ConversionHJ = DEvent4 * 100;
            double PointsHJ = .8465 * Math.Pow((ConversionHJ - 75), 1.42);
            PointsHJ = Math.Round(PointsHJ, 0, MidpointRounding.ToEven);
            return (PointsHJ);
        }
        public double CalculatePoints400m(double DEvent5)
        {
            double Points400m = 1.53775 * Math.Pow((82 - DEvent5), 1.81);
            Points400m = Math.Round(Points400m, 0, MidpointRounding.ToEven);
            return (Points400m);
        }
        public double CalculatePoints110HH(double DEvent6)
        {
            double Points110HH = 5.74352 * Math.Pow((28.5 - DEvent6), 1.92);
            Points110HH = Math.Round(Points110HH, 0, MidpointRounding.ToEven);
            return (Points110HH);
        }
        public double CalculatePointsDisc(double DEvent7)
        {
            double PointsDisc = 12.91 * Math.Pow((DEvent7 - 4), 1.1);
            PointsDisc = Math.Round(PointsDisc, 0, MidpointRounding.ToEven);
            return (PointsDisc);
        }
        public double CalculatePointsPV(double DEvent8)
        {
            double ConversionPV = DEvent8 * 100;
            double PointsPV = .2797 * Math.Pow((ConversionPV - 100), 1.35);
            PointsPV = Math.Round(PointsPV, 0, MidpointRounding.ToEven);
            return (PointsPV);
        }
        public double CalculatePointsJavelin(double DEvent9)
        {
            double PointsJavelin = 10.14 * Math.Pow((DEvent9 - 7), 1.08);
            PointsJavelin = Math.Round(PointsJavelin, 0, MidpointRounding.ToEven);
            return (PointsJavelin);
        }
        public double CalculatePoints1500m(double DEvent10)
        {
            double Points1500m = 0.03768 * Math.Pow((480 - DEvent10), 1.85);
            Points1500m = Math.Round(Points1500m, 0, MidpointRounding.ToEven);
            return (Points1500m);
        }
        public double CalculatePointsDecathlon(double Points100m, double PointsLJ, double PointsSP, double PointsHJ, double Points110HH, double Points400m, double PointsDisc, double PointsPV, double PointsJavelin, double Points1500m)
        {
            double DecathlonScore = PointsSP + PointsPV + PointsLJ + PointsJavelin + PointsHJ + PointsDisc + Points400m + Points1500m + Points110HH + Points100m;
            DecathlonScore = Math.Round(DecathlonScore, 0, MidpointRounding.ToEven);
            return (DecathlonScore);
        }
        public double CalculatePoints100H(double HEvent1)
        {
            double Point100H = 9.23076 * Math.Pow((26.7 - HEvent1), 1.835);
            Point100H = Math.Round(Point100H, 0, MidpointRounding.ToEven);
            return Point100H;
        }
        public double CalculatePointsHJHept(double HEvent2)
        {
            double ConversionHJ1 = HEvent2 * 100;
            double HeptPointsHJ = 1.84523 * Math.Pow((ConversionHJ1 - 75), 1.348);
            HeptPointsHJ = Math.Round(HeptPointsHJ, 0, MidpointRounding.ToEven);
            return (HeptPointsHJ);
        }
        public double CalculatePointsSPHept(double HEvent3)
        {
            double HeptPointsSP = 56.0211 * Math.Pow((HEvent3 - 1.5), 1.05);
            HeptPointsSP = Math.Round(HeptPointsSP, 0, MidpointRounding.ToEven);
            return (HeptPointsSP);
        }
        public double CalculatePoints200mHept(double HEvent4)
        {
            double HeptPoints200m = 4.99087 * Math.Pow((42.5 - HEvent4), 1.81);
            HeptPoints200m = Math.Round(HeptPoints200m, 0, MidpointRounding.ToEven);
            return (HeptPoints200m);
        }
        public double CalculatePointsLJHept(double HEvent5)
        {
            double ConversionLJ1 = HEvent5 * 100;
            double HeptPointsLJ = .188807 * Math.Pow((ConversionLJ1 - 210), 1.41);
            HeptPointsLJ = Math.Round(HeptPointsLJ, 0, MidpointRounding.ToEven);
            return (HeptPointsLJ);
        }
        public double CalculatePointsJavelinHept(double HEvent6)
        {
            double HeptPointsJavelin = 15.9803 * Math.Pow((HEvent6 - 3.8), 1.04);
            HeptPointsJavelin = Math.Round(HeptPointsJavelin, 0, MidpointRounding.ToEven);
            return (HeptPointsJavelin);
        }
        public double CalculatePoints800mHept(double HEvent7)
        {
            double HeptPoints800m = .11193 * Math.Pow((254 - HEvent7), 1.88);
            HeptPoints800m = Math.Round(HeptPoints800m, 0, MidpointRounding.ToEven);
            return (HeptPoints800m);
        }
        public double CalculatePointsHeptathlon(double Point100H, double HeptPointsHJ, double HeptPointsSP, double HeptPoints200m, double HeptPointsLJ, double HeptPointsJavelin, double HeptPoints800m)
        {
            double HeptathlonScore = Point100H + HeptPointsSP + HeptPointsLJ + HeptPointsJavelin + HeptPointsHJ + HeptPoints800m + HeptPoints200m;
            HeptathlonScore = Math.Round(HeptathlonScore, 0, MidpointRounding.ToEven);
            return HeptathlonScore;
        }
    }
}
