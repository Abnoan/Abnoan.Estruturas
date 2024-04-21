using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        #region If-Else e Ternario
        int idade = 18;
        if (idade >= 18)
        {
            Console.WriteLine("Você é maior de idade!");
        }
        else
        {
            Console.WriteLine("Você é menor de idade!");
        }

        idade = 150;
        bool maiorIdade = idade >= 18;
        if (maiorIdade)
        {
            Console.WriteLine("Você é maior de idade!");
        }
        else if (idade >= 150)
        {
            Console.WriteLine("Humanos podem ter 150 anos?");
        }
        else
        {
            Console.WriteLine("Você é menor de idade!");
        }

        int numero = 5;
        string resultado = numero > 0 ? "Positivo" : "Negativo ou Zero";
        Console.WriteLine(resultado);

        idade = 18;
        string maiorDeIdade = idade >= 18 ? "Você é maior de idade!" : "Você é menor de idade!";
        Console.WriteLine(maiorDeIdade);
        #endregion

        #region Array uni
        int[] numeros = [1, 2, 3, 4, 5]; // Cria um array com 5 números
        int primeiroNumero = numeros[0]; // Pega o primeiro número
        numeros[2] = 10; // Muda o terceiro elemento para 10
        #endregion

        #region Array Multi - Matriz

        int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 } }; // Matriz 2x3
        int elemento = matriz[0, 2]; // Acessa o terceiro elemento da primeira linha
        matriz[1, 1] = 20; // Muda o elemento do meio para 20

        #endregion

        #region Loops      

        double temperaturaMotor = 150.0;
        double temperaturaSegura = 50.0;

        while (temperaturaMotor > temperaturaSegura)
        {
            temperaturaMotor -= 5.0;  // reduz a temperatura em 5 graus por ciclo
            Console.WriteLine($"Resfriando o motor... Temperatura atual: {temperaturaMotor}°C");
        }

        Console.WriteLine("Motor resfriado e pronto para ser desligado.");

        int totalRelatorios = 5;
        int relatoriosEnviados = 0;

        do
        {
            // Simula o envio de um relatório
            relatoriosEnviados++;  // incrementa o contador de relatórios enviados
            Console.WriteLine($"Enviando relatório {relatoriosEnviados} de {totalRelatorios}.");
        } while (relatoriosEnviados < totalRelatorios);

        Console.WriteLine("Todos os relatórios foram enviados com sucesso.");


        string[] frutas = ["Maçã", "Banana", "Cereja"];
        foreach (var fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        #endregion

        #region Manipulação de Array
        // Declaração e inicialização de um array unidimensional
        numeros = [5, 3, 9, 1, 6];

        // Acessar elementos
        Console.WriteLine("Acesso ao terceiro elemento: " + numeros[2]);

        // Adição (não é direta em arrays, mas vamos simular expandindo o array)
        Array.Resize(ref numeros, 6);
        numeros[5] = 10; // Adicionando novo elemento no final
        Console.WriteLine("Elemento adicionado: " + numeros[5]);

        // Remoção (não é direta, removeremos o terceiro elemento simulando com resize e copy)
        int[] numerosAjustados = new int[numeros.Length - 1];
        Array.Copy(numeros, 0, numerosAjustados, 0, 2); // Copia os dois primeiros elementos
        Array.Copy(numeros, 3, numerosAjustados, 2, numeros.Length - 3); // Pula o terceiro elemento
        numeros = numerosAjustados;
        Console.WriteLine("Array após remoção: " + string.Join(", ", numeros));

        // Cópia de array
        int[] copiaNumeros = new int[numeros.Length];
        Array.Copy(numeros, copiaNumeros, numeros.Length);
        Console.WriteLine("Cópia do array: " + string.Join(", ", copiaNumeros));

        // Redimensionar array (diminuir)
        Array.Resize(ref numeros, 4);
        Console.WriteLine("Array redimensionado: " + string.Join(", ", numeros));

        // Ordenar array
        Array.Sort(numeros);
        Console.WriteLine("Array ordenado: " + string.Join(", ", numeros));

        // Reverter array
        Array.Reverse(numeros);
        Console.WriteLine("Array revertido: " + string.Join(", ", numeros));

        #endregion

        #region Switch
        string esporteFavorito = "volei";
        switch (esporteFavorito)
        {
            case "futebol":
            case "volei":
                Console.WriteLine("Ótima escolha! Ambos são esportes de equipe muito populares.");
                break;
            case "natacao":
                Console.WriteLine("Natação é excelente para saúde cardiovascular e força.");
                break;
            case "corrida":
                Console.WriteLine("Corrida é perfeita para melhorar a resistência e saúde geral.");
                break;
            case "surf":
                Console.WriteLine("Surf é incrível para quem ama o mar e busca aventura.");
                break;
            default:
                Console.WriteLine("Esporte não reconhecido. Tente novamente!");
                break;
        }

        idade = 16;
        bool gostaDeAcao = true;
        string categoria;
        string recomendacao;

        switch (idade)
        {
            case 10:
                categoria = "Infantil";
                recomendacao = "Toy Story.";
                break;
            case 13:
                categoria = "Juvenil";
                if (gostaDeAcao)
                {
                    recomendacao = "Homem-Aranha: No Aranhaverso.";
                }
                else
                {
                    recomendacao = "Encanto.";
                }
                break;
            case 16:
                categoria = "Adolescente";
                recomendacao = gostaDeAcao ? "Vingadores: Ultimato." : "A Culpa é das Estrelas.";
                break;
            case 18:
                categoria = "Adulto";
                recomendacao = gostaDeAcao ? "John Wick." : "O Grande Hotel Budapeste.";
                break;
            default:
                categoria = "Não classificado";
                recomendacao = "Confira outras opções disponíveis.";
                break;
        }

        Console.WriteLine($"Para a idade {idade}, a categoria é: {categoria}. Recomendamos: {recomendacao}");
        #endregion
        #region Exercicios

        #region If-Else
        idade = 29;

        if (idade >= 13 && idade <= 17)
        {
            Console.WriteLine("Adolescente");
        }
        else if (idade >= 18 && idade <= 35)
        {
            Console.WriteLine("Jovem adulto");
        }
        else if (idade >= 36 && idade <= 59)
        {
            Console.WriteLine("Adulto");
        }
        else if (idade >= 60)
        {
            Console.WriteLine("Idoso");
        }
        else
        {
            Console.WriteLine("Criança ou pré-adolescente");
        }
        #endregion

        #region Ternario
        numero = 4; // Exemplo de número
        resultado = numero % 2 == 0 ? "Par" : "Ímpar"; // verifica se o número é par (ou seja, se o resto da divisão do número por 2 é igual a zero)
        Console.WriteLine($"O número {numero} é {resultado}.");

        #endregion

        #region Switch
        int mes = 4; // Exemplo de mês

        switch (mes)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Verão");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("Outono");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("Inverno");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("Primavera");
                break;
            default:
                Console.WriteLine("Mês inválido");
                break;
        }
        #endregion
        #region For
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
        #endregion

        #region Foreach
        string[] palavras = ["maçã", "banana", "cereja", "damasco"];
        foreach (var palavra in palavras)
        {
            if (palavra.Contains('a'))
            {
                Console.WriteLine(palavra);
            }
        }

        #endregion

        #region While
        string texto = "Cascata de caracteres onde contamos quantos 'a' aparecem.";
        int contador = 0;
        int index = 0;
        while (index < texto.Length)
        {
            if (texto[index] == 'a')
            {
                contador++;
            }
            index++;
        }
        Console.WriteLine($"Número de caracteres 'a' no texto: {contador}");
        #endregion

        #region Do-While
        int volumeTanque = 0;
        int volumeMaximo = 100;
        do
        {
            volumeTanque += 10;  // Adiciona 10 litros de água por iteração
            Console.WriteLine("Volume atual do tanque: " + volumeTanque + " litros");
        } while (volumeTanque < volumeMaximo);
        #endregion

        #endregion

    }
}