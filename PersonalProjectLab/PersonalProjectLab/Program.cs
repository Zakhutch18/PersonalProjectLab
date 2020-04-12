using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a Multi-Event track and field score calculator");
            bool Continue;
            Continue = true;
            while (Continue)
            {
               
                Console.WriteLine("Would you like to calculate the score for Decathlon or Heptathlon?");
                // 100m is Decathlon Event 1
                double DEvent1;
                // Long Jump is Decathlon Event 2
                double DEvent2;
                // Shotput is Decathlon Event 3
                double DEvent3;
                // High Jump is Decathlon Event 4
                double DEvent4;
                // 400m is Decathlon Event 5
                double DEvent5;
                // 110m Hurdles is Decathlon Event 6
                double DEvent6;
                // Discus is Decathlon Event 7
                double DEvent7;
                // Pole Vault is Decathlon Event 8
                double DEvent8;
                // Javelin is Decathlon Event 9
                double DEvent9;
                // 1500m is Decathlon Event 10
                double DEvent10;
                // 100m Hurdles is Heptathlon Event 1
                double HEvent1;
                // High Jump is Heptathlon Event 2
                double HEvent2;
                // Shotput is Heptathlon Event 3
                double HEvent3;
                // 200m is Heptathlon Event 4
                double HEvent4;
                // Long Jump is Heptathlon Event 5 
                double HEvent5;
                // Javelin Throw is Heptathlon Event 6
                double HEvent6;
                // 800m is Heptathlon Event 7
                double HEvent7;
                string Event;
                string input = "";

                Event = Console.ReadLine();

                if (Event == "Decathlon")
                {
                    Console.WriteLine("Enter 100m Time in Seconds");
                    input = Console.ReadLine();
                    DEvent1 = double.Parse(input);
                    MultiEventScore score100m = new MultiEventScore();
                    double Points100m = score100m.CalculatePoints100m(DEvent1);

                    Console.WriteLine("Enter Jong Jump Distance in Meters");
                    input = Console.ReadLine();
                    DEvent2 = double.Parse(input);
                    MultiEventScore LJ = new MultiEventScore();
                    double PointsLJ = LJ.CalculatePointsLJ(DEvent2);

                    Console.WriteLine("Enter the Shotput Throw Distance in Meters");
                    input = Console.ReadLine();
                    DEvent3 = double.Parse(input);
                    MultiEventScore SP = new MultiEventScore();
                    double PointsSP = SP.CalculatePointsSP(DEvent3);

                    Console.WriteLine("Enter the High Jump Height in Meters");
                    input = Console.ReadLine();
                    DEvent4 = double.Parse(input);
                    MultiEventScore HJ = new MultiEventScore();
                    double PointsHJ = HJ.CalculatePointsSP(DEvent4);

                    Console.WriteLine("Enter 400m Time in Seconds");
                    input = Console.ReadLine();
                    DEvent5 = double.Parse(input);
                    MultiEventScore Score400m = new MultiEventScore();
                    double Points400m = Score400m.CalculatePointsSP(DEvent5);

                    Console.WriteLine("Enter 110m Hurdles Tine in Seconds");
                    input = Console.ReadLine();
                    DEvent6 = double.Parse(input);
                    MultiEventScore Score110HH = new MultiEventScore();
                    double Points110HH = Score110HH.CalculatePointsSP(DEvent6);

                    Console.WriteLine("Enter The Discus Throw Distance in Meters");
                    input = Console.ReadLine();
                    DEvent7 = double.Parse(input);
                    MultiEventScore Disc = new MultiEventScore();
                    double PointsDisc = Disc.CalculatePointsSP(DEvent7);

                    Console.WriteLine("Enter The Pole Vault Height in Meters");
                    input = Console.ReadLine();
                    DEvent8 = double.Parse(input);
                    MultiEventScore PV = new MultiEventScore();
                    double PointsPV = PV.CalculatePointsSP(DEvent8);

                    Console.WriteLine("Enter the Javelin throw Distance in Meters");
                    input = Console.ReadLine();
                    DEvent9 = double.Parse(input);
                    MultiEventScore Javelin = new MultiEventScore();
                    double PointsJavelin = Javelin.CalculatePointsSP(DEvent9);

                    Console.WriteLine("Enter the 1500m time in seconds");
                    input = Console.ReadLine();
                    DEvent10 = double.Parse(input);
                    MultiEventScore Score1500m = new MultiEventScore();
                    double Points1500m = Score1500m.CalculatePointsSP(DEvent10);

                    MultiEventScore stats = new MultiEventScore();
                    double DecathlonScore = stats.CalculatePointsDecathlon(Points100m, PointsLJ, PointsSP, PointsHJ, Points110HH, Points400m, PointsDisc, PointsPV, PointsJavelin, Points1500m);
                    Console.WriteLine("Decathlon Score is " + DecathlonScore);

                }
                else
                {
                    Console.WriteLine("Enter 100m hurdles time in seconds");
                    input = Console.ReadLine();
                    HEvent1 = double.Parse(input);
                    MultiEventScore stat = new MultiEventScore();
                    double Point100H = stat.CalculatePoints100H(HEvent1);

                    Console.WriteLine("Enter the High Jump Height in Meters");
                    input = Console.ReadLine();
                    HEvent2 = double.Parse(input);
                    MultiEventScore stats = new MultiEventScore();
                    double HeptPointsHJ = stats.CalculatePointsHJHept(HEvent2);


                    Console.WriteLine("Enter the Shotput Throw Distance in Meters");
                    input = Console.ReadLine();
                    HEvent3 = double.Parse(input);
                    MultiEventScore HeptSP = new MultiEventScore();
                    double HeptPointsSP = HeptSP.CalculatePointsSPHept(HEvent3);

                    Console.WriteLine("Enter 200m time in seconds");
                    input = Console.ReadLine();
                    HEvent4 = double.Parse(input);
                    MultiEventScore Hept200m = new MultiEventScore();
                    double HeptPoints200m = Hept200m.CalculatePoints200mHept(HEvent4);

                    Console.WriteLine("Enter Long Jump Distance in Meters");
                    input = Console.ReadLine();
                    HEvent5 = double.Parse(input);
                    MultiEventScore HeptLJ = new MultiEventScore();
                    double HeptPointsLJ = HeptLJ.CalculatePointsLJHept(HEvent5);

                    Console.WriteLine("Enter Javelin Throw Distance in Meters");
                    input = Console.ReadLine();
                    HEvent6 = double.Parse(input);
                    MultiEventScore HeptJavelin = new MultiEventScore();
                    double HeptPointsJavelin = HeptJavelin.CalculatePointsJavelinHept(HEvent6);

                    Console.WriteLine("Enter 800m time in seconds");
                    input = Console.ReadLine();
                    HEvent7 = double.Parse(input);
                    MultiEventScore Hept800m = new MultiEventScore();
                    double HeptPoints800m = Hept800m.CalculatePoints800mHept(HEvent7);

                    MultiEventScore statsH = new MultiEventScore();
                    double HeptathlonScore = statsH.CalculatePointsHeptathlon(Point100H, HeptPoints200m, HeptPoints800m, HeptPointsHJ, HeptPointsJavelin, HeptPointsLJ, HeptPointsSP);
                    Console.WriteLine("Heptathlon Score is " + HeptathlonScore);



                }

                string input1 = "";
                Console.WriteLine("Do you wish to calculate another Score? Type 'Yes' or 'No'");
                input1 = Console.ReadLine();
                if (input1 == "No")
                {
                    Continue = false;
                }
            }

            Console.WriteLine("The program has ended. Have a nice day. (: ");

        }
    }
}