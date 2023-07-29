namespace StreamShare.Domain.DTOs.GerenciaNet.Response
{
    public class GetLocationResponseDTO
    {
        public Parametros Parametros { get; set; }
        public LocationDTO[] Loc { get; set; }
    }

    public class Parametros
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public Paginacao Paginacao { get; set; }
    }

    public class Paginacao
    {
        public int PaginaAtual { get; set; }
        public int ItensPorPagina { get; set; }
        public int QuantidadeDePaginas { get; set; }
        public int QuantidadeTotalDeItens { get; set; }
    }
}
