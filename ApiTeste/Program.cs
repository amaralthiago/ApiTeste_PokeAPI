namespace ApiTeste
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Informe o id ou nome do Pokemon: ");
            string value = Console.ReadLine();

            PokeAPIServices pokeAPIServices = new PokeAPIServices();

            PokeAPI pokemon = await pokeAPIServices.Integracao(value);

            if (!pokemon.ValidaRetorno)
            {
                Console.WriteLine("Pokemon Encontrado!");
                Console.WriteLine($"ID: {pokemon.id}");
                Console.WriteLine($"Nome: {pokemon.name}");
                Console.WriteLine($"XP Base: {pokemon.base_experience}");
                Console.WriteLine($"Altura: {pokemon.height}");
                Console.WriteLine($"Ordem: {pokemon.order}");
                Console.WriteLine($"Peso: {pokemon.weight}lbs");
            }
            else
            {
                Console.WriteLine("Pokemon não encontrado!");
            }
        }
    }
}