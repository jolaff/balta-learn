namespace BlogLearn.Screens.UserScreens;

public static class UpdateUserScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("      Atualizar Usuário      ");
        WriteLine("-----------------------------");
        WriteLine();

        Write("Entre com o Id: ");
        var id = ReadLine();
        WriteLine();
        Write("Digite o nome: ");
        var name = ReadLine();
        WriteLine();
        Write("Digite o email: ");
        var email = ReadLine();
        WriteLine();
        Write("Digite a Bio: ");
        var bio = ReadLine();
        WriteLine();
        Write("Imagem será gerada via linha de código");
        WriteLine();
        Write("Digite o slug: ");
        var slug = ReadLine();
        var hash = "hash-hash";
        var image = "http://imagem.do.usuario";

        Update(new User
        {
            Id = int.Parse(id),
            Name = name,
            Email = email,
            PasswordHash = hash,
            Bio = bio,
            Image = image,
            Slug = slug
        });

        WriteLine();
        Write("Pressione qualquer tecla para voltar...");
        ReadKey();
    }

    private static void Update(User user)
    {
        try
        {
            var repository = new Repository<User>(Database.Connection);
            repository.Update(user);
            WriteLine();
            WriteLine();
            WriteLine($"Usuário atualizado com sucesso!");
        }
        catch (Exception ex)
        {
            WriteLine();
            WriteLine("Não foi possível atualizar o usuário");
            WriteLine(ex.Message);
        }
    }
}