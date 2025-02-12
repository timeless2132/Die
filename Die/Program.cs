namespace Die
{
    public class Die
    {
        
        private Random _generator;
        private int _roll;

        public Die()
        {
            _generator = new Random(); 
            _roll = _generator.Next(1, 7);
        }
        
        static void Main(string[] args)
        {
           
        }
    }
}
