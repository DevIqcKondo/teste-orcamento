using System;

namespace exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dados para o orçamento
         double comprimento = 0;
         double complementoComprimento = 0; 
         double largura = 0;
         double complementoLargura = 0;
         double somaComprimento = 0;
         double somaLargura = 0;
         double valorMaterial = 0;
         double resultado = 0;
         string nomeMaterial;
         string descricao;
         double x = 0;

         //coletando dados do usuário 
         Console.BackgroundColor=ConsoleColor.White;
         Console.ForegroundColor=ConsoleColor.Black;
         Console.WriteLine("----------------------");
         Console.WriteLine("- DADOS DO ORÇAMENTO -");
         Console.WriteLine("----------------------");

         Console.Write("Descrição do produto: ");
         descricao = Convert.ToString(Console.ReadLine());
         Console.ReadKey();

         Console.Write("Insira o nome do material: ");
         nomeMaterial = Convert.ToString(Console.ReadLine());
         Console.ReadKey();

         Console.Write("Insira o comprimento: ");
         comprimento = Convert.ToDouble(Console.ReadLine());
         Console.ReadKey();

         Console.Write("Insira o complemento do comprimento: ");
         complementoComprimento = Convert.ToDouble(Console.ReadLine());
         Console.ReadKey();

         Console.Write("Insira a largura: ");
         largura = Convert.ToDouble(Console.ReadLine());
         Console.ReadKey();

         Console.Write("Insira o complemento da largura: ");
         complementoLargura = Convert.ToDouble(Console.ReadLine());
         Console.ReadKey();

         Console.Write("Insira o valor do M²: ");
         valorMaterial = Convert.ToDouble(Console.ReadLine());
         Console.ReadKey();

         Console.WriteLine();

         //CALCULANDO ORÇAMENTO

         somaComprimento = comprimento + complementoComprimento;
         somaLargura = largura + complementoLargura;
         resultado = (somaComprimento * somaLargura) * valorMaterial;
         x = Math.Round(resultado, 2);

         Console.WriteLine("----------------------");
         Console.WriteLine("- VALOR DO ORÇAMENTO -");
         Console.WriteLine("----------------------");

         Console.WriteLine("Material: "+nomeMaterial);
         Console.WriteLine("Descrição do produto: "+descricao);
         Console.WriteLine("Valor total do orçamento: "+x);
         Console.ResetColor();
         





     }
    }
}