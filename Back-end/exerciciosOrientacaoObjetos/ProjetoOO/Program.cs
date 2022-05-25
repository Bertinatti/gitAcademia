// See https://aka.ms/new-console-template for more information

/*
 * Exercício desafio para treinar o início da Orientação a Objetos.
 **/

Pessoa p = new Pessoa();
p.Nome = "NOME";
p.Sexo = "SEXO";
p.StatusCivil = "ESTADO CIVIL";
p.Idade = 0;
p.Altura = 0;
p.Peso = 0;

p.ExibirDados();

Lampada l = new Lampada();
l.potencia = 9;
l.ligar();
Console.WriteLine("Ligado? " + l.ligado + "\nPotência = " + l.potencia);
l.desligar();
Console.WriteLine("Ligado? " + l.ligado + "\nPotência = " + l.potencia);
bool x = l.estaLigado();
double n = l.retornaPotencia();
Console.WriteLine("A potência da lâmpada cadastrada é: " + n);
Console.WriteLine("A lâmpada está {0}", x ? "ligada" : "desligada");

public class Lampada
{
    // atributos
    public bool ligado;
    public double potencia;

    //métodos
    public void ligar()
    {
        Console.WriteLine("A lâmpada está sendo ligada!");
        ligado = true;
    }

    public void desligar()
    {
        Console.WriteLine("A lâmpada está sendo desligada!");
        ligado = false;
    }

    public bool estaLigado()
    {
        return ligado;
    }

    public double retornaPotencia()
    {
        return potencia;
    }

    public Lampada()
    {

    }
}
public class Carro
{
    private string modelo, marca, cor, placa;
    private bool ligado;

    public string Modelo { get => modelo; set => modelo = value; }
    public string Marca { get => marca; set => marca = value; }
    public string Cor { get => cor; set => cor = value; }
    public string Placa { get => placa; set => placa = value; }
    public bool Ligado { get => ligado; set => ligado = value; }

    public void ligar()
    {
        Ligado = true;
    }
    public void desligar()
    {
        Ligado = false;
    }
    public bool exibirLigado()
    {
        return Ligado;
    }
}
public class Pessoa
{
    private string nome, sexo, statusCivil;
    private int idade;
    private double altura, peso;

    public string Nome { get => nome; set => nome = value; }
    public string Sexo { get => sexo; set => sexo = value; }
    public string StatusCivil { get => statusCivil; set => statusCivil = value; }
    public int Idade { get => idade; set => idade = value; }
    public double Altura { get => altura; set => altura = value; }
    public double Peso { get => peso; set => peso = value; }

    public void ExibirDados()
    {
        Console.WriteLine("=================Dados=================\n" +
                          "Nome: {0}\n" +
                          "Sexo: {1}\n" +
                          "Estado Civil: {2}\n" +
                          "Idade: {3}\n" +
                          "Altura: {4}\n" +
                          "Peso: {5}\n" +
                          "=======================================\n", this.Nome, this.Sexo, this.StatusCivil, this.Idade, this.Altura, this.Peso);
    }
}