using System.Linq.Expressions;

namespace Lab6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dean dean = new Dean();
            Lecturer teacher = new Lecturer("Валерий Михайлович", dean);
            // проверка отчётов
            dean.Verify();

            dean.Verify();

            teacher.StopGrades();
        }
    }
}

