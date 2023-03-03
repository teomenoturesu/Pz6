using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz61
{
    internal class Session
    {
        private byte semester;
        private byte test;
        private byte exam;
        public Session(byte semester, byte test, byte exam)
        {
            this.semester = semester;
            this.test = test;
            this.exam = exam;
        }
        internal static void Average(List<Session> sessions)
        {
            Console.Write("Сессии со средним количеством экзаменов: ");
            var average = sessions.Where(i => i.exam >= sessions.Average(i => i.exam)).ToList();
            average.ForEach(i => Console.Write(i.semester + "\t"));
        }
        internal static void Save(List<Session> sessions)
        {
            Console.Write("\nСессии с количеством зачетов от 1 до 3: ");
            var tests = sessions.Where(i => i.test >= 1 && i.test <= 3).ToList();
            tests.ForEach(i => Console.Write(i.semester + "\t"));
        }
    }
}
