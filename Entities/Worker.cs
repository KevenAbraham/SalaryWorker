using System.Collections.Generic; //importar listas
using Course.Entities.Enum; //importar o enum que está na pasta enums.

namespace Course.Entities 
{
    class Worker
    {
        public string Name { get; set; } // Nome do trabalhador
        public WorkerLevel Level { get; set; } // nível do trabalhador, tipo worker lever (enum). Para isso, cria-se primeiro o enum.
        public double BaseSalary { get; set; } //salario base de todo funcionario (salario padrão).
        public Department Department { get; set; } //apesar de no diagrama nao constar que tem essa propriedade, há uma conxão. Com isso, associamos a uma outra classe. Com base nos dados digitados, eu vou querer instanciar na memória o objeto do tipo trabalhador, com o nome, nível e o salário base, e associado ao objeto, o departamento. 
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //de acordo com o diagrama, um trabalhador pode ter vários contratos. Contudo, dentro da classe trabalhador, cria-se uma propriedade chamada contracts e o tipo. Como ela é vários contratos, vai ter que ser uma lista de contratos. É uma lista pois um trabalhador pode ter vários contratos, de acordo com o diagrama...  A lista já é instanciada para garantir que ela nao seja nula

        public Worker() //construtor vazio
        {
        }

        //construtor com argumentos. As associações Para Muitos não são incluídas, pois não é usual passar uma lista instanciada no construtor do objeto. Essa lista começará vazia, e só depois eu vou adicionando os objetos conforme a minha necessidade. Por via de regra, sempre que houver uma associação para muitos, você não vai incluir ela no construtor.
        public Worker(string name, WorkerLevel level, double baseSalary, Department department) 
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //Esse método vai receber o HourContract Contract e ele vai acessar a lista de contratos e adicionar o contrato que chegar como parametro de entrada. 
        public void AddContract(HourContract contract) //adiciono um conjunto de atributos da classe hourcontracts.
        {
            Contracts.Add(contract); //adiciona
        }

        public void RemoveContract(HourContract contract) //remove o contrato fornecido no método.
        {
            Contracts.Remove(contract); //remove
        }

        public double Income(int year, int month) //ultima operação para descobrir quanto o funcionario ganhou. 
        {
            double sum = BaseSalary; //o trabalhador ja tem um salario base, contudo, a soma é inciada com o salario base do trabalhador.
            foreach (HourContract obj in Contracts) //foreach para percorrer a minha lista de contratos.
            {
                if (obj.Date.Year == year && obj.Date.Month == month) //se esse contrato na minha lista, no mesmo ano e mes, o contrato entra na soma.
                {
                    sum += obj.TotalValue(); //totalvalue() é a operação que retorna o valor do contrato.
                }
            }
            return sum; // retorna a soma.
        }
    }
}

