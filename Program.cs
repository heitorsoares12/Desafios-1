using System; 

class Problem {

    static void Main(string[] args) { 

            double a, b, mediaP;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            
            //complete com as variaveis
            if(a>10 || b>10)
            {
            Console.WriteLine("Valor invalido");
            Environment.Exit(0);}
            if (a<0 || b<0)
            {
            Console.WriteLine("Valor invalido");
            Environment.Exit(0);}

            mediaP = (( a * 3.5) + ( b * 7.5)) / (3.5 + 7.5);

            Console.WriteLine("MEDIA = {0}", mediaP.ToString("0.00000"));

    }

}