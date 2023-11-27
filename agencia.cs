class Agencia
{
    public int Numero { get; }
    public string CEP { get; }
    public string TelefoneContato { get; }
    public string Banco BancoAssociado { get; private set; }

    public void Agencia(int numero, string cep, string telefoneContato)
    {
        Numero = numero;
        CEP = cep;
        TelefoneContato = telefoneContato;
    }

    public void AssociarBanco(Banco banco)
    {
        BancoAssociado = banco;
    }
}
