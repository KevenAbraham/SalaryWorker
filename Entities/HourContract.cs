using System;

namespace Course.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; } //data do contrato
        public double ValuePerHour { get; set; } //valor por hora do contrato
        public int Hours { get; set; } //duração em horas do contrato

        public HourContract() //construtor padrão
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hours) //construtor com os argumentos
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue() //método de retorno do valor total do contrato
        {
            return ValuePerHour * Hours;
        }
    }
}