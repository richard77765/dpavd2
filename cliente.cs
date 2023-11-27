

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