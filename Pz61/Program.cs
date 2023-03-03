namespace Pz61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Session session1 = new Session(1, 1, 4);
            Session session2 = new Session(2, 2, 4);
            Session session3 = new Session(3, 3, 9);
            Session session4 = new Session(4, 4, 8);
            List<Session> sessions = new List<Session>() { session1, session2, session3, session4};
            Session.Average(sessions);
            Session.Save(sessions);
        }
    }
}