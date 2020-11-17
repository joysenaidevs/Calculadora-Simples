using System;

namespace Calculadora_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedir a operação
            //pedir o primeiro numeor
            //pedir o segundo numero

            Console.WriteLine("Digite a operação que deseja fazer \n Soma,Subtracao, Multiplicacao, Divisao");

            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o primeiro numero");
            float num1 = float.Parse(Console.ReadLine());

            // ALT + SHIFT + Seta para baixo
            Console.WriteLine("Digite o segundo numero");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = 0;
            
        //     //IF ELSE 
        //    if(operacao == "Soma"){
        //        resultado = num1 + num2; 
        //    }else if(operacao == "Subtracao"){
        //      resultado = num1 - num2;
        //    }else if(operacao == "Multiplicação"){
        //       resultado = num1 * num2;
        //    }else if(operacao == "Divisao"){
        //        resultado = num1 / num2;

        //    }else{
        //        Console.WriteLine("Operação Invalida!");
        //    }

            //Switch case - Usar quando obtiver mais de uma operação 
            switch(operacao){
                case "Soma":
                    resultado = num1+num2;
                    break;
                case "Subtração":
                    resultado = num1-num2;
                    break;
                case "Multiplicação":
                    resultado = num1*num2;
                    break;
                case "Divisão":
                    resultado = num1/num2;
                    break;
                default:
                    Console.WriteLine("Operação Invalida!");
                    break;

            }
            //Concatenacao
            //Console.WriteLine("Calculo : "+num1+" e "+num2+" = Resultado : " +resultado);

            //Interpolacao
            Console.WriteLine($"Calculo: {num1} e {num2} = Resultado : {resultado}");
        }   
    }
}
