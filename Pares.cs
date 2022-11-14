using System;
class Principal {
    static void Main() {

        int i, comeco, fim, soma, novocomeco;
        soma = 0;

        Console.Write("Digite com que número deseja começar a análise: ");
        comeco= int.Parse(Console.ReadLine());

        Console.Write ("Digite em que número deseja terminar a análise: ");
        fim= int.Parse(Console.ReadLine());

        if (comeco > fim){
            Console.WriteLine("O valor do começo é menor que o valor de fim. Sendo assim, os valores serão invertidos.");
            novocomeco = comeco;
            comeco = fim;
            fim = novocomeco;
        }
        if (comeco == fim){
            Console.WriteLine("O valor do começo é idêntico ao fim. Será subtraído 1 número no valor de começo.");
            comeco--;
        }

        for (i = comeco; i <= fim; i++){
            if (i % 2 == 0 ){
                Console.WriteLine("{0} é par.", i);
            }
            if (i % 2 != 0){
                soma += i;
            }
        }
        if (soma > 1){
            Console.Write("\nA soma dos números ímpares é igual a {0}.",soma);
        }
        Console.ReadLine();
    }
}