
        Console.WriteLine("Encontrando plano cartesiano.\n");
        Console.WriteLine("Digite as coordenadas (x, y) de um ponto:");
        
        Console.Write("Digite a coordenada x: ");
        double x;
        bool xValido = double.TryParse(Console.ReadLine(), out x);
        
        Console.Write("Digite a coordenada y: ");
        double y;
        bool yValido = double.TryParse(Console.ReadLine(), out y);
        
        string resulta;

        if (!xValido || !yValido)
        {
            Console.WriteLine("As coordenadas devem ser números válidos.");
            return;
        }
        
       if (x == 0 && y == 0) resulta = "o ponto 0";
       else if (x == 0) {resulta = "o eixo y";}
       else if (y == 0) {resulta = "o eixo x";}
       else if (y > 0)
       {
           if (x > 0)
               resulta = "o quadrante 1";
           else
               resulta = "o quadrante 2";
       }
       else
       {
    if (x < 0)
        resulta = "o quadrante 3";
    else
        resulta = "o quadrante 4";
}

Console.WriteLine($"\nO ponto ({x}, {y}) fica n{resulta}.");
       