namespace Repository.Entidades
{
    public class Factura
    {
        public int Id { get; set; }
        public string NroFactura { get; set; }
        public DateTime FechaHora { get; set; }
        public double Total { get; set; }
        public double TotalIva5 { get; set; }
        public double TotalIva10 { get; set; }
        public double TotalIva { get; set; }
        public string TotalLetras { get; set; }
        public string? Sucursal { get; set; }
        public int IdCliente { get; set; }
        public Cliente? Cliente { get; set; }
        public string? Total_Iva_10 { get; internal set; }
    }
}
