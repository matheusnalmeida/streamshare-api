namespace StreamShare.Domain.DTOs.GerenciaNet
{
    public class LocationDTO
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string TipoCob { get; set; }
        public DateTime Criacao { get; set; }
        public string Txid { get; set; }
    }
}
