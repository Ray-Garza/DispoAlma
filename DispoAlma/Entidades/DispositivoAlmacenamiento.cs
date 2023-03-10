namespace DispoAlma.Entidades
{
    public class DispositivoAlmacenamiento
    {
        public int Id { get; set; }
        public string Nombre_dispositivo { get; set; }

        public int Almacenamiento_dispositivo { get; set; }
        public string Descripcion_dispositivo { get; set; }
        public int Velocidad_escritura { get; set; }
        public int Velocidad_lectura { get; set; } 
        public int Cantidad { get;set; }

        //:o
        public int ProveedorId { get; set; }
        public Proveedor provedor { get; set; }
    }
}
