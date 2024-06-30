public class Usuario
{
    public string Nome;
    public string Senha;

    public void SetSenha()
    {
        Senha = "123";
        if (Nome == "Nome1")
        {
            Senha = "Admin";
        }
        else if (Nome == "Nome4")
        {
            Senha = "Abracadabra";
        }
    }

    public void ExibirSenha()
    {
        Console.WriteLine("Senha: " + senha);
    }

    public void ResetarSenha()
    {
        Senha = "abc";
    }
 
}