namespace mvc.Models;

public class Denuncia
{
    public int DenunciaId { get; set; }
    public DateTime Data { get; set; }
    public string Endereco { get; set; }
    public string Referencia { get; set; }
    public string Descricao { get; set; }

    public int TipoOcorrenciaId { get; set; }
    public virtual TipoOcorrencia TipoOcorrencia { get; set; }
}
