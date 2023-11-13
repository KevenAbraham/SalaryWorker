namespace Course.Entities
{
    class Department
    {
        public string Name { get; set; }

        // Construtor padrão
        public Department()
        {
        }

        // Contrutor para receber o nome como argumento
        public Department(string name)
        {
            Name = name;
        }
    }
}