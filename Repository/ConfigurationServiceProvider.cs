namespace Repository
{
    public class ConfigurationServiceProvider
    {
        public int Id { get; set; }
        public string Provider { get; set; }
        public string Identifier { get; set; }
        public string Type { get; set; }
        public string Endpoint { get; set; }
        public string Action { get; set; }
        public string XSLTRequest { get; set; }
        public string XSLTResponse { get; set; }
    }
}