

using Ativid_SP2;

Console.WriteLine("Informar nome:");
string nome = Console.ReadLine();

Console.WriteLine("Informar endereço:");
string endereco = Console.ReadLine();

Console.WriteLine("Pessoa fisica (f) ou juridica (j)?");
string tipo = Console.ReadLine();

if(tipo == "f") {

    PessoaFisica pf = new PessoaFisica (){
        nome = nome,
        endereco = endereco,
    };

    Console.WriteLine("Informar o CPF: ");
    pf.CPF = Console.ReadLine();

    Console.WriteLine("Informar o RG: ");
    pf.RG = Console.ReadLine();

    Console.WriteLine("Informar o valor de compra: ");
    float valor  = float.Parse(Console.ReadLine());

    pf.PagarImposto(valor);

    Console.WriteLine("-----Pessoa Fisica-----");
    Console.WriteLine("Nome: " + pf.nome);
    Console.WriteLine("Endereço: " + pf.endereco);
    Console.WriteLine("CPF: " + pf.CPF);
    Console.WriteLine("RG: " + pf.RG);
    Console.WriteLine("Valor de compra: " + pf.valor.ToString("C"));
    Console.WriteLine("Imposto: " + pf.valorImposto);
    Console.WriteLine("Total a pagar: " + pf.total.ToString("C"));


}
else if (tipo == "j"){

    PessoaJuridica pj = new PessoaJuridica() {
        nome = nome,
        endereco = endereco,
    };

    Console.WriteLine("Informar o CNPJ: ");
    pj.CNPJ = Console.ReadLine();

    Console.WriteLine("Informar o IE: ");
    pj.IE = Console.ReadLine();

    Console.WriteLine("Informar o valor de compra: ");
    float valor  = float.Parse(Console.ReadLine());

    pj.PagarImposto(valor);

    Console.WriteLine("-----Pessoa Juridica-----");
    Console.WriteLine("Nome: " + pj.nome);
    Console.WriteLine("Endereço: " + pj.endereco);
    Console.WriteLine("CNPJ: " + pj.CNPJ);
    Console.WriteLine("IE: " + pj.IE);
    Console.WriteLine("Valor de compra: " + pj.valor.ToString("C"));
    Console.WriteLine("Imposto: " + pj.valorImposto);
    Console.WriteLine("Total a pagar: " + pj.total.ToString("C"));

}
