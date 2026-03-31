/*
    Requisitos
        1. Ao iniciar o jogo, deve ser selecionada uma palavra aleatória à partir de uma lista.
        2. O jogador poderá chutar a palavra secreta letra por letra, cada letra certa deverá ser apresentada,
        assim como as letras erradas.
        3. O jogador poderá cometer até cinco erros, caso erre pela quinta vez, ou acerte a palavra a partida
        acaba.
        4. Deve-se apresentar um desenho da forca sendo atualizado a cada erro.
*/

// 1. Ao iniciar o jogo, deve ser selecionada uma palavra aleatória à partir de uma lista.
string palavraSecreta = "ABACATE";

// 2. O jogador poderá chutar a palavra secreta letra por letra, cada letra certa
// deverá ser apresentada.
char[] letrasCorretas = new char[7];

for (int contadorLetras = 0; contadorLetras < 7; contadorLetras++)
{
    letrasCorretas[contadorLetras] = '_';
}

int contadorErros = 0;

bool jogadorAcertou = false;
bool jogadorPerdeu = false;

while (!jogadorAcertou && !jogadorPerdeu)
{
    // Console.Clear();
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("Jogo da Forca");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("Erros cometidos: " + contadorErros + " erros");
    Console.Write("Chutes: ");

    for (int contadorLetras = 0; contadorLetras < 7; contadorLetras++)
    {
        Console.Write(letrasCorretas[contadorLetras]);
    }

    Console.WriteLine("\n--------------------------------------------");
    Console.Write("Digite uma letra: ");
    char chute = Convert.ToChar(Console.ReadLine());

    bool letraFoiEncontrada = false;

    for (int contadorPalavraSecreta = 0; contadorPalavraSecreta < palavraSecreta.Length; contadorPalavraSecreta++)
    {
        char letraSecretaAtual = palavraSecreta[contadorPalavraSecreta];

        if (chute == letraSecretaAtual)
        {
            letrasCorretas[contadorPalavraSecreta] = chute;
            letraFoiEncontrada = true;
        }
    }

    if (!letraFoiEncontrada)
        contadorErros++;

    string letrasCorretasCompleta = string.Join("", letrasCorretas);

    if (palavraSecreta == letrasCorretasCompleta)
    {
        Console.WriteLine($"Parabéns, você acertou! A palavra era: {palavraSecreta}");
        jogadorAcertou = true;
    }

    if (contadorErros > 5)
    {
        Console.WriteLine($"Que pena, você errou! A palavra era: {palavraSecreta}");
        jogadorPerdeu = true;
    }
}

Console.Write("Digite ENTER para sair...");
Console.ReadLine();
