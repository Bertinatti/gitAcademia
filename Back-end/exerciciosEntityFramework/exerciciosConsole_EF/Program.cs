// See https://aka.ms/new-console-template for more information
using exerciciosConsole_EF;

using (var contexto = new ClienteContext())
{
    Console.WriteLine("Iniciando o programa!!!");

    //contexto.Clientes.Add(new Cliente() { Nome = "Leonardo Bertinatti", Email = "leonardo.bertinatti@ufn.edu.br"});

    //var cliente = contexto.Clientes.First();
    //cliente.CPF = "000.000.000-00";

    //contexto.Clientes.Add(new Cliente() { Nome = "Alexandre Zamberlan", Email = "alexz@ufn.edu.br", CPF = "000.000.000-00" });

    //Cliente id = contexto.Clientes.Single(c => c.Id == 2);
    //contexto.Clientes.Remove(id);

    //contexto.SaveChanges();

    var quantidade_clientes = contexto.Clientes.Count();

    Console.WriteLine("O número de clientes cadastrados na loja é de: " + quantidade_clientes);

    Console.WriteLine("==============================================================");
    foreach (var c in contexto.Clientes)
    {
        Console.WriteLine("Nome: " + c.Nome + "\nE--mail: " + c.Email +"\nCPF: " + c.CPF);
        Console.WriteLine("==============================================================");
    }
}
