namespace StreamShare.Domain.DTOs.GerenciaNet.Response
{
    public class GetChargeResponseDTO
    {
        public string Txid { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public int Revisao { get; set; }
        public string Chave { get; set; }
        public string SolicitacaoPagador { get; set; }
        public CalendarChargeDTO Calendario { get; set; }
        public DebtorChargeDTO Devedor { get; set; }
        public ValueChargeDTO Valor { get; set; }
        public LocationDTO Loc { get; set; }
    }

    public class CalendarChargeDTO
    {
        public DateTime Criacao { get; set; }
        public string Expiracao { get; set; }
    }

    public class DebtorChargeDTO
    {
        public string Cnpj { get; set; }
        public string Nome { get; set; }
    }

    public class ValueChargeDTO
    {
        public string Original { get; set; }
    }


    public class PixTransactionInformationDTO
    {
        public string EndToEndId { get; set; }
        public string Txid { get; set; }
        public string Valor { get; set; }
        public DateTime Horario { get; set; }
        public string InfoPagador { get; set; }
        public DevolutionsDTO[] Devolucoes { get; set; }
    }

    public class DevolutionsDTO
    {
        public string id { get; set; }
        public string rtrId { get; set; }
        public string valor { get; set; }
        public DevolutionsTimeDTO horario { get; set; }
        public string status { get; set; }
    }

    public class DevolutionsTimeDTO
    {
        public DateTime solicitacao { get; set; }
    }


}
