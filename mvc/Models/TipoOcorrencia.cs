namespace mvc.Models;

public class TipoOcorrencia
{
    public int TipoOcorrenciaId { get; set; }
    public string Descricao { get; set; }

    public List<Denuncia> Denuncias { get; set; }
}
