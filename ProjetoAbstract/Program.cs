using ProjetoAbstract.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAbstract.Entites.Enums;
using ProjetoAbstract.Entites;
using System.Globalization;

namespace ProjetoAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figura> list = new List<Figura>();
          
            Console.Write("Entre com numero de figuras: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Figura #{0}: ",i);
                Console.Write("Retangulo ou Circulo (R/C): ");
                char Resp = char.Parse(Console.ReadLine());
                if (Resp == 'R' ||  Resp == 'r')
                {
                    Console.Write("Color (Preto/Vermelho/Azul): ");
                    EnumColor color = (EnumColor)Enum.Parse(typeof(EnumColor), Console.ReadLine());
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Retangulo retangulo = new Retangulo(color, altura, largura);
                    list.Add(retangulo);
                    Console.WriteLine();
                }else if (Resp == 'C' || Resp == 'c')
                {
                    Console.Write("Color (Preto/Vermelho/Azul): ");
                    EnumColor color = (EnumColor)Enum.Parse(typeof(EnumColor), Console.ReadLine());
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Circulo circulo = new Circulo(color, raio);
                    list.Add(circulo);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Dados incorretos, Tente novamente!!");
                }
            }
            Console.WriteLine("Area Das Figuras: ");
            foreach (Figura figura in list)
            {
                Console.WriteLine(figura.Area().ToString("f2"),CultureInfo.InvariantCulture);
            }
            Console.ReadLine();
        }
    }
}
