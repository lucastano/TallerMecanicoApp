namespace tallerMecanico.API.DTOs
{
    public class AddPartDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //TODO: ver como plantear lo de compatibilidad 
        // deberia hacer una clase marcas y modelos para almacenar marcas y modelos de vehiculos existentes
        //public List<string> Compatibility { get; set; }
        public int OEMCode { get; set; }
        public double Cost { get; set; }
    }
}
