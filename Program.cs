using System;

class Program
{
    static void Main()
    {
        
        Cliente clienteJoao = new Cliente("João", "123456789", 1990);

       
        try
        {
            Conta contaSemTitular = new Conta(null, 1000.0);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Erro ao criar conta: {e.Message}");
        }

        Conta contaJoao = new Conta(clienteJoao, 1000.0);

        
        try
        {
            contaJoao.Sacar(100.0);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Erro ao sacar: {e.Message}");
        }

       
        Console.WriteLine($"Saldo da conta de {contaJoao.Titular.Nome}: R${contaJoao.Saldo}");

      
        Cliente clienteMaria = new Cliente("Maria", "987654321", 1985);
        Conta contaMaria = new Conta(clienteMaria, 500.0);


        try
        {
            contaJoao.Transferir(contaMaria, 200.0);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Erro ao transferir: {e.Message}");
        }

        Console.WriteLine($"Saldo da conta de {contaJoao.Titular.Nome}: R${contaJoao.Saldo}");
        Console.WriteLine($"Saldo da conta de {contaMaria.Titular.Nome}: R${contaMaria.Saldo}");
    }
}

class Cliente
{
    public string Nome { get; }
    public string CPF { get; }
    public int AnoNascimento { get; }

    public Cliente(string nome, string cpf, int anoNascimento)
    {
        Nome = nome;
        CPF = cpf;
        AnoNascimento = anoNascimento;
    }
}