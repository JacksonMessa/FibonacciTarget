int n1; 
int[] nf = new int[2];
nf[0] = 1;
nf[1] = 1;

Console.WriteLine("Digite um número e o programa dirá se ele pertence a sequência de Fibonnaci");
n1 = int.Parse(Console.ReadLine());
while (nf[1] < n1)
{
    int aux = nf[1];
    nf[1] = nf[1] + nf[0];
    nf[0] = aux;
}

if (n1 == nf[1] || n1 == 0)
{
    Console.WriteLine("Pertence");
}
else
{
    Console.WriteLine("Não Pertence");
}