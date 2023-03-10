namespace DispoAlma.Entidades
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre_proveedor { get; set; }
        public string Direccion_proveedor { get; set; }
        public string Telefono_proveedor { get; set; }
        public string Correo_proveedor { get; set; }
        public string RFC { get; set; }

        public List<DispositivoAlmacenamiento> Dispositivos { get; set;}
    }
}
