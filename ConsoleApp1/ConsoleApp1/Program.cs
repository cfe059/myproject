using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BMI();
        }

        public static void BMI()
        {
            //string cm, kg;
            float cmP, kgP, BMI;

            Console.WriteLine("身長を入力してください。");
            //cm = float.Parse(Console.ReadLine());
            cmP = NumReadfloat();

            Console.WriteLine("体重を入力してください。");
            //kg = float.Parse(Console.ReadLine());
            kgP = NumReadfloat();

            cmP /= 100;

            BMI = (kgP / (cmP * cmP));
            Console.WriteLine($"あなたのBMIは{BMI}");
            Console.WriteLine($"あなたは{BMIrating(BMI)}");
        }
        //BMIを表示する

        static string BMIrating(float bmif)
        {
            double bmi = (double)bmif;
            double[] std = new double[] { 0, 16.00, 17.00, 18.50, 25.00, 29.99, 34.99, 40.00 };
            int count = 0;

            for (int i = 0; i <= 8; i++)
            {
                if (std[i] <= bmi && std[i + 1] > bmi)
                {
                    count = i;
                    break;
                }
            }
            switch (count)
            {
                case 0:
                    return ("痩せすぎ（重度の痩せ）");
                case 1:
                    return ("痩せすぎ（中度の痩せ）");
                case 2:
                    return ("痩せ気味（軽度の痩せ）");
                case 3:
                    return ("標準体重");
                case 4:
                    return ("過体重（前肥満）");
                case 5:
                    return ("肥満（１度）");
                case 6:
                    return ("肥満（２度）");
                case 7:
                    return ("肥満（３度）");
                default:
                    return ("判定不能");
            }
        }
        //BMIの数値によってWHO基準で判定する

        static float NumReadfloat()
        {
            float az;
            string a;
            //Console.WriteLine("数値を入力してください。");
            a = (Console.ReadLine());
            bool parseOK = float.TryParse(a, out az);
            if (parseOK)
            {
                //Console.WriteLine("パース成功:" + parseOK);
            }
            else
            {
                Console.WriteLine("パース失敗。数値を入力してください。");
            }
            return (az);
        }
        //string型で入力された数値をfloat型に変換する


    }
}
