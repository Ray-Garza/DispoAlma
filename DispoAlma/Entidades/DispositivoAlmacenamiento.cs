namespace DispoAlma.Entidades
{
    public class DispositivoAlmacenamiento
    {
        public int id_dispositivo { get; set; }
        public string nombre_dispositivo { get; set; }

        public int almacenamiento_dispositivo { get; set; }
        public string descripcion_dispositivo { get; set; }
        public int velocidad_escritura { get; set; }
        public int velocidad_lectura { get; set; } 
        public int cantidad { get;set; }
    }
}
