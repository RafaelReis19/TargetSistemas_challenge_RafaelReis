
public class Program
{
    private static void Main(string[] args)
    {
        
        //Resultado da questão 1:
        ImprimirSomaQuestao1();

        //Questão 1 finalizada
        Console.WriteLine("---------------------\n");


        //Resultado da questão 2:
        int numFibanocci = 55;

        CalcularSeqDeFibonacci(numFibanocci);
        if(numFibanocci == 55 | numFibanocci == 34 | numFibanocci == 21 
            | numFibanocci == 13 | numFibanocci == 8 | numFibanocci == 5 
            | numFibanocci == 3 | numFibanocci == 2 | numFibanocci == 1)
        {
            Console.WriteLine("pertence");
        }
        else{
            Console.WriteLine("não pertence");
        }

        //Questão 2 finalizada
        Console.WriteLine("---------------------\n");

        //Resultado da questão 3:
        /* 3) Descubra a lógica e complete o próximo elemento:  
            a) 1, 3, 5, 7, 9 
            A lógica é: de um elemento para o outro, aumenta 2 algarismos.

            b) 2, 4, 8, 16, 32, 64, 128 
            Lógica: o valor de um elemento é exatamente o dobro do valor do elemneto anterior.

            c) 0, 1, 4, 9, 16, 25, 36, 49
            Lógica: Do 0 para o 1, aumenta-se 1 número (n).
            Sucessivamente para os próximos valores, aumenta-se n + 2.
            Exemplo: Do 1 para o 4 = n (que é 1) + 2 = 3, portanto 1 + 3 = 4;
            Do 4 para o 9 = n (que ficou 3) + 2 = 5, portanto 4 + 5 = 9;
            E assim por diante até o n de 36 (que ficou 11) 11 + 2 = 13, portanto 36 + 13 = 49.

            d) 4, 16, 36, 64, 100
            Lógica: Do 4 para o 16, aumentou 12 números, que é igual a 4(número anterior) + 8;
            Do 16 para o 36, aumentou 12 mais 8 que é igual a 20;
            Do 36 para o 64, aumentou 20 mais 8, que é igual a 28;
            Sendo assim, do 64 para o próximo número vai aumentar 28 mais 8, que é igual a 36
            então 64 + 36 = 100;
            Assim por diante.


            e) 1, 1, 2, 3, 5, 8, 13
            Lógica: É a sequência de Fibonacci, onde se inicia com 0 e 1 e os próximos valores
            serão resultantes da soma entre os dois valores anteriores a ele.
            Sendo assim: 1, 1 pois 1 + 0 = 1 | 1, 1, 2 pois 1 + 1 = 2 | ..., 5, 8, 13 pois 5 + 8 = 13

            f) 2,10, 12, 16, 17, 18, 19, 200
            Lógica: a sequência mostra apenas números inteiros que comçam com a letra D.
            Assim: (D)ois, (D)oze, (D)ezesseis, Dezessete... (D)uzentos. 

           Questão 3 finalizada. 
        */



        //Resposta da questão 4:
        /* 
            4 - Dois veículos (um carro e um caminhão) saem respectivamente de cidades opostas pela mesma rodovia. 
            O carro de Ribeirão Preto em direção a Franca, a uma velocidade constante de 110 km/h e o caminhão 
            de Franca em direção a Ribeirão Preto a uma velocidade constante de 80 km/h.
            Quando eles se cruzarem na rodovia, qual estará mais próximo a cidade de Ribeirão Preto?
            IMPORTANTE:
            a) Considerar a distância de 100km entre a cidade de Ribeirão Preto <-> Franca.

            b) Considerar 2 pedágios como obstáculo e que o caminhão leva 5 minutos a mais para passar em cada um deles e o carro possui tag de pedágio (Sem Parar)

            c) Explique como chegou no resultado. 

            Resposta: Quando o carro e o caminhão se cruzarem na rodovia, os dois estarão há mesma distância de Ribeirão Preto.
            Pois eles se "cruzaram" ou seja, se encontraram em um determinado ponto da rodovia, onde os dois estão juntos.
            Logo, os dois estão ha mesma distância de Ribeirão Preto.
            c) Explique como chegou no resultado.
            Resposta: Analisando o enunciado da questão e das informações a) e b),
            presentes na questão, pela lógica, eu deduzi e cheguei a conclusão que
             os dois veículos se encontram há mesma distância de Ribeirão Preto,
            quando se cruzam na rodovia.
            
            Questão 4 finalizada.
        */



        //Resultado da questão 5:
        string textoOriginal;
        string textoInvertido;

        Console.WriteLine("Digite algum texto: ");
        textoOriginal = Console.ReadLine();
        textoInvertido = InverterString(textoOriginal);
        Console.WriteLine($"Seu texto invertido ficou igual a: \n{textoInvertido}");

        //Questão 5 finalizada. Teste concluído.



    }


    /* 1) Observe o trecho de código abaixo:

        int INDICE = 13, SOMA = 0, K = 0;
        enquanto K < INDICE faça
        {
            K = K + 1;
            SOMA = SOMA + K;
        }
        imprimir(SOMA);

        Ao final do processamento, qual será o valor da variável SOMA? */

    public static void ImprimirSomaQuestao1()
    {
        int indice = 13, soma = 0, k = 0;

        do
        {
            k = k + 1;
            soma = soma + k;
            
        } while(k < indice);
        Console.WriteLine(soma);

    }

    /* 2)Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor 
    sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), 
    escreva um programa na linguagem que desejar onde, informado um número, ele calcule a
    sequência de Fibonacci e retorne uma mensagem avisando se o número informado
    pertence ou não a sequência. */

    public static void CalcularSeqDeFibonacci(int num)
    {
        //num = 8;
        int a = 0, b = 1, c = 0;

        for(int count = 0; count <= num; count++)
        {
            c = a + b;
            Console.WriteLine(c);
            a = b;
            b = c;

        }


    }

    /* 
        5) Escreva um programa que inverta os caracteres de um string.
        IMPORTANTE:
        a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
        b) Evite usar funções prontas, como, por exemplo, reverse; 
    */

    public static string InverterString(string str)
    {
        char[] charArray = str.ToCharArray();
        string textoInvertido = String.Empty;

        for(int count = charArray.Length - 1; count >= 0; count--)
        {
            textoInvertido += charArray[count];
        }

        return textoInvertido;

    }

     

    
}
