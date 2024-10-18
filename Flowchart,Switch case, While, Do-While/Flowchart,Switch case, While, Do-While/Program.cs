namespace Flowchart_Switch_case__While__Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Verilmiş n tam ədədinin sadə və ya mürəkkəb ədəd olduğunu tapan alqoritm.


            console.writeline("bir n ededi daxil edin:");

            int n = convert.toınt32(console.readline());

            if (n <= 1)
            {
                console.writeline("sade ve murekkeb eded deyil.");
                return;

            }

            for (int i = 2; ; i++)
            {
                if (n % i == 0)
                {
                    console.writeline($"{n} murekkeb eded.");
                    return;
                }


                else
                {
                    console.writeline($"{n} sade eded.");
                    break;
                }
            }




            //2.Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın.Məs: 23452, output: 5 , Məs: 456, output: 3


            Console.WriteLine("n tam ededi daxil edin:");

            int n = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            do
            {
                n /= 10;
                count++;
            }
            while (n > 0);
            Console.WriteLine(count);






        }
    }
}
