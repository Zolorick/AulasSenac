using Trajeto_bala_de_canhão;
Entradas firula = new Entradas();

double g = 9.81; // Aceleração da gravidade (m/s²)

// Colocando dados do lançamento
firula.OutraLinha();
firula.Lancamento();
firula.Linha();


/*
 * Primeiro vai converter graus em radianos
 * Depois, calcular o tempo de voo
 * Então altura e distância máximas
 */

double anguloRadianos = firula.anguloLancamento * (Math.PI / 180);

double tempoVoo = (2 * firula.velocidadeInicial * Math.Sin(anguloRadianos)) / g;
Console.WriteLine($"Tempo de voo: {tempoVoo:F2} s");
Console.WriteLine();

double alturaMaxima = Math.Pow(firula.velocidadeInicial * Math.Sin(anguloRadianos), 2) / (2 * g);
Console.WriteLine($"Altura máxima: {alturaMaxima:F2} m");
Console.WriteLine();

double distanciaMaxima = (Math.Pow(firula.velocidadeInicial, 2) * Math.Sin(2 * anguloRadianos)) / g;
Console.WriteLine($"Distância máxima: {distanciaMaxima:F2} m");

firula.Linha();



// tabela de valores por segundo
Console.WriteLine();
Console.WriteLine("As variaveis estão em segundo, metro ou metros por segundo");
Console.WriteLine("Tempo    | Posição X    | Posição Y    | Vel. X    | Vel. Y");

for (double t = 0; t <= tempoVoo; t += 0.1)
{
    double posicaoX = firula.velocidadeInicial * Math.Cos(anguloRadianos) * t;
    double posicaoY = (firula.velocidadeInicial * Math.Sin(anguloRadianos) * t) - (0.5 * g * Math.Pow(t, 2));
    double velocidadeX = firula.velocidadeInicial * Math.Cos(anguloRadianos);
    double velocidadeY = firula.velocidadeInicial * Math.Sin(anguloRadianos) - g * t;

    // quando y negativa o objeto pousa
    if (posicaoY < 0)
    {
        posicaoY = 0;
        velocidadeY = 0;
    }

    Console.WriteLine($"{t:F1}      | {posicaoX:F2}         | {posicaoY:F2}         | {velocidadeX:F2}      | {velocidadeY:F2}");
}

firula.OutraLinha();