namespace BlogLearn.Screens.UserScreens;

public static class CreateUserScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("      Cadastrar Usuário      ");
        WriteLine("-----------------------------");
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
        WriteLine("Imagem será gerada via linha de código");
        WriteLine();
        Write("Digite o slug: ");
        var slug = ReadLine();
        var hash = "hash-hash";
        var image = "http://imagem.do.usuario";

        Create(new User
        {
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

    private static void Create(User user)
    {
        try
        {
            var repository = new Repository<User>(Database.Connection);
            repository.Create(user);
            WriteLine();
            WriteLine();
            WriteLine($"Usuário {user.Name} cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            WriteLine();
            WriteLine("Não foi possível cadastrar o usuário");
            WriteLine(ex.Message);
        }
    }
}