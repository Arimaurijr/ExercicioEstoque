using ExercicioLista;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Produto> estoque = new List<Produto>();

        Console.WriteLine("Count: " + estoque.Count);
        Console.WriteLine("Capacity: " + estoque.Capacity);

        estoque.Add(new Produto(1,"Borracha"));
       //Console.WriteLine("01 - Count: " + estoque.Count);
        //Console.WriteLine("01 - Capacity: " + estoque.Capacity);

        estoque.Add(new Produto(2, "Caderno"));
        //Console.WriteLine("02 - Count: " + estoque.Count);
        //Console.WriteLine("02 - Capacity: " + estoque.Capacity);

        estoque.Add(new Produto(3, "Apontador"));
        //Console.WriteLine("03 - Count: " + estoque.Count);
        //Console.WriteLine("03 - Capacity: " + estoque.Capacity);

        Console.WriteLine("\n\nElementos da Lista de Estoque ORDENADOS:");
        List<Produto> estoqueordenado = estoque.OrderBy(Produto => Produto.Nome).ToList();

        //foreach(Produto produto in estoque) 
        for(int i = 0; i < estoqueordenado.Count; i++)
        {
            Console.WriteLine(estoqueordenado[i].ToString());
        }
        
        Console.WriteLine("Count: " + estoque.Count);
        Console.WriteLine("Capacity: " + estoque.Capacity);

        Object obj = (Object)estoque[0];

       int x = estoqueordenado.BinarySearch(estoqueordenado,obj);
    }
}