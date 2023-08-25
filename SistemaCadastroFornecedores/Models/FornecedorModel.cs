using System.ComponentModel.DataAnnotations;

public class FornecedorModel
{
    public int ID { get; set; }

    [StringLength(100)]
    public string Nome { get; set; }



    [RegularExpression("^[0-9]*$", ErrorMessage = "CNPJ deve conter apenas dígitos.")]
    [StringLength(14)]
    public string CNPJ { get; set; }

    public string Especialidade { get; set; }

    [RegularExpression("^[0-9]*$", ErrorMessage = "CEP deve conter apenas dígitos.")]
    [StringLength(8)]
    public string CEP { get; set; }

    [StringLength(255)]
    public string Endereco { get; set; }

    public  FornecedorModel(int id, string nome, string cnpj, string especialidade, string cep, string endereco)
    {
        ID = id;
        Nome = nome;
        CNPJ = cnpj;
        Especialidade = especialidade;
        CEP = cep;
        Endereco = endereco;

    }
}
