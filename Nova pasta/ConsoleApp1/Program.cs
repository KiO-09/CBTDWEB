
string? nome;
Console.WriteLine("Digite seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("Olá " + nome + "!");
Console.ReadLine();

int n2=0;
float media=0;
int n1=0;
Console.WriteLine ("digite uma nota");
n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("digite outra nota");
n2 = Convert.ToInt32(Console.ReadLine());
media = (n1 + n2)/2;
Console.WriteLine ("sua média é: " + media);

Console.ReadLine();