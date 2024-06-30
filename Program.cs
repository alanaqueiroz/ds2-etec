Console.WriteLine("Hello, World!");

Usuario user = new Usuario();
user.Nome = "Nome1"; 
Usuario user2 = new Usuario();
user2.Nome = "Nome2"; 
Usuario user3 = new Usuario();
user3.Nome = "Nome3"; 
Usuario user4 = new Usuario();
user4.Nome = "Nome4"; 

List<Usuario> lista = new List<Usuario>();
lista.Add(user);
lista.Add(user2);
lista.Add(user3);
lista.Add(user4);

foreach(Usuario itemList in lista)
{
    Console.WriteLine(itemList.Nome);
    itemList.SetSenha();
    //itemList.ExibirSenha();
    itemList.ResetarSenha();
    itemList.ExibirSenha();
}

Console.ReadKey();