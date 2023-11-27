using System;

class Program
{
    static void Main()
    {
       
        Banco meuBanco = new Banco("Meu Banco", 1);

       
        Agencia minhaAgencia = new Agencia(123, "12345-678", "123456789");

        
        meuBanco.AdicionarAgencia(minhaAgencia);

        
        Cliente clienteJoao = new Cliente("João", "123456789", 1990);

      
        Conta contaJoao = new Conta(clienteJoao, minhaAgencia, 1000.0);

       
        Console.WriteLine($"A idade de {clienteJoao.Nome} em anos romanos é: {CalculaIdadeRomana(clienteJoao.AnoNascimento)}");


        try
        {
            contaJoao.Sacar(100.0);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Erro ao sacar: {e.Message}");
        }


        Console.WriteLine($"Saldo da conta de {contaJoao.Titular.Nome}: R${contaJoao.Saldo}");


        Cliente orcVelho = new Cliente("Grommash", "Orc123", -5000);
        Conta contaOrc = new Conta(orcVelho, minhaAgencia, 1000000.0);

        Console.WriteLine($"A idade do Orc em anos romanos é: {CalculaIdadeRomana(orcVelho.AnoNascimento)}");
    }

    static string CalculaIdadeRomana(int anoNascimento)
    {
        int idade = DateTime.Now.Year - anoNascimento;
        return RomanConverter.ToRoman(idade);
    }
}