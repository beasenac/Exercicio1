using System.ComponentModel.Design;

int numero1,numero2,numero3,maiorN,menorN;
Console.WriteLine("Digite o primeiro números:");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o terceiro número:");
numero3 = Convert.ToInt32(Console.ReadLine());

if (numero1 > numero2 && numero1 > numero3 )
{
  
    Console.WriteLine("O maior número é:" + numero1);
}
else if(numero2 > numero3)
{
    Console.WriteLine("O maior número é:" + numero2);
}
else
{
    Console.WriteLine("O maior número é :" + numero3);
}
if (numero1 < numero2 && numero1 < numero3)
{

    Console.WriteLine("O menor número é:" + numero1);
}
else if (numero2 < numero3)
{
    Console.WriteLine("O menor número é:" + numero2);
}
else
{
    Console.WriteLine("O menor número é:" + numero3);
}





