namespace Portafolio.Servicios
{
    public class ServicioUnico
    {
        public ServicioUnico()
        {
            ObtenenrGuid = new Guid();
        }

        public Guid ObtenenrGuid { get; set; }
    }

    public class ServicioDelimitado
    {
        public ServicioDelimitado()
        {
            ObtenenrGuid = new Guid();
        }

        public Guid ObtenenrGuid { get; set; }
    }

    public class ServicioTransitorio
    {
        public ServicioTransitorio()
        {
            ObtenenrGuid = new Guid();
        }

        public Guid ObtenenrGuid { get; set; }
    }
}
