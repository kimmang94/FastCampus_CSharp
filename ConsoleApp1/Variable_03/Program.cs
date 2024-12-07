namespace Data_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 120;
            byte b = 255;
            short c = 30000;
            long d = 100000000000000;
            ulong f = 100000000000000;
            int num = 100;

            Console.WriteLine("sbyte a : " + a);
            Console.WriteLine("byte b : " + b);
            Console.WriteLine("short c : " + c);
            Console.WriteLine("long d : " + d);
            Console.WriteLine("ulong f : " + f);
            Console.WriteLine("int num : " + num);

            // 정수 데이터 형태
            // 가장 빈번하게 사용되는 형태

            // 정수 리터럴 접두사 (10진수는 암묵적 변환)
            // - 2진수 : ob(OB) -> ob00001111
            // - 16진수 : ox(OX) -> oxFF
        }
    }
}
