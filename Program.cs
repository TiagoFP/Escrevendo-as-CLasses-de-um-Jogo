using ClasseJogo.models;
Hero h = new Hero();
Console.WriteLine("Digite o seu nome");
h.nome = Console.ReadLine();
Console.WriteLine("Digite a sua idade");
h.idade = int.Parse(Console.ReadLine());
Console.WriteLine("Qual o seu tipo de heroi");
Console.WriteLine("Para escolher o tipo Mago, digite 1");
Console.WriteLine("Para escolher o tipo Mago, digite 2");
Console.WriteLine("Para escolher o tipo Mago, digite 3");
Console.WriteLine("Para escolher o tipo Mago, digite 4");
Console.WriteLine("Para sair, digite 5");
h.opcao = int.Parse(Console.ReadLine());
h.atacar();

