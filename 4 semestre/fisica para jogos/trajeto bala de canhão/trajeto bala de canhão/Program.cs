using Trajeto_bala_de_canhão;

Entradas setup = new Entradas();

setup.linhaIgual();

// Entrada de dados
setup.entrada();

setup.linha();

// Conversão de graus para radianos
double anguloRadianos = setup.anguloLancamento * (Math.PI / 180);

// Constantes
double g = 9.81; // Aceleração da gravidade (m/s²)

// Cálculo da altura máxima
double alturaMaxima = Math.Pow(setup.velocidadeInicial * Math.Sin(anguloRadianos), 2) / (2 * g);
Console.WriteLine($"Altura máxima: {alturaMaxima:F2} m");

Console.WriteLine();

// Cálculo do tempo de voo
double tempoVoo = (2 * setup.velocidadeInicial * Math.Sin(anguloRadianos)) / g;
Console.WriteLine($"Tempo de voo: {tempoVoo:F2} s");

Console.WriteLine();

// Cálculo da distância máxima
double distanciaMaxima = (Math.Pow(setup.velocidadeInicial, 2) * Math.Sin(2 * anguloRadianos)) / g;
Console.WriteLine($"Distância máxima: {distanciaMaxima:F2} m");

setup.linha();

// Criação da tabela de valores
Console.WriteLine("\nTabela de valores (t, x, y, v_x, v_y):");
Console.WriteLine("Tempo (s) | Posição X (m) | Posição Y (m) | Vel. X (m/s) | Vel. Y (m/s)");

for (double t = 0; t <= tempoVoo; t += 0.1)
{
    double posicaoX = setup.velocidadeInicial * Math.Cos(anguloRadianos) * t;
    double posicaoY = (setup.velocidadeInicial * Math.Sin(anguloRadianos) * t) - (0.5 * g * Math.Pow(t, 2));
    double velocidadeX = setup.velocidadeInicial * Math.Cos(anguloRadianos);
    double velocidadeY = setup.velocidadeInicial * Math.Sin(anguloRadianos) - g * t;

    // Para garantir que a posição Y não fique negativa
    if (posicaoY < 0)
    {
        posicaoY = 0;
        velocidadeY = 0;
    }

    Console.WriteLine($"{t:F1}      | {posicaoX:F2}         | {posicaoY:F2}         | {velocidadeX:F2}      | {velocidadeY:F2}");
}

setup.linhaIgual();