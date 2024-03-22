namespace Stroytelling
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StateMachine sm = new StateMachine();
            while (true)
            {
                sm.Update();
            }
        }
    }
}
