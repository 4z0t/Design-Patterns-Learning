using System.Linq.Expressions;

namespace Lab6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dean dean = new Dean();
            Lecturer teacher1 = new Lecturer("Дмирий олегович", dean);
            Lecturer teacher2 = new Lecturer(" Иван Иванович ", dean);
            // проверка отчётов
            dean.Verify();

            dean.Verify();

            teacher1.StopGrades();
            teacher2.StopGrades();
        }
    }
}

