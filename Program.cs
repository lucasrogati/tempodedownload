double tamanhobytes, velocidadembps, tempomin;

Console.WriteLine("Tempo de Download\n");

Console.Write("Tamanho do arquivo em MB: ");
tamanhobytes = Convert.ToDouble(Console.ReadLine());

Console.Write("Velocidade da conexão em Mbps...: ");
velocidadembps = Convert.ToDouble(Console.ReadLine());

tempomin = tamanhobytes * 8 / velocidadembps / 60;

Console.WriteLine($"\nO tempo estimado de download: {tempomin:N1} minutos");
