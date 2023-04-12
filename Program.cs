namespace Lecture_2_Constructors
{
    internal class Program
    {
         static List<Bullet> _bullets = new List<Bullet>();
        static void Main(string[] args)
        {
            //Main access modifiers:

            //internal
            //everything in namespace can be access this modifier

            //private
            //Everything in a class can be accessed with this modifier

            //protected
            //parent class and any of its children can be accessed with this modifier

            //public
            //everything can be accessed through any project in your solution.

            //creating object with required parameters from constructor in Gym class
            Gym gym = new Gym(100, 5, 22);

            //displaying our ToString() override from the Gym class
            Console.WriteLine(gym.ToString());

            Preload();
            Bullet bill = new Bullet("Bill", 0, 0, 1);


            int count = 0;
            int end = 1000;
            while (count <= end)
            {
                foreach (Bullet bullet in _bullets)
                {
                    bullet.UpdateLocation();
                    Console.WriteLine(bullet);
                }
                Thread.Sleep(300);
                count++;
                Console.Clear();
            }

        }

        public static void Preload()
        {
            string[] names = { "Bill", "Sam", "George", "Bob", "Tom" };
            Random rand = new Random();
            foreach(string name in names)
            {
                int x = rand.Next(0, 12);
                int y = rand.Next(0, 20);
                float v = rand.Next(-3, 3) + (float)rand.NextDouble();
                _bullets.Add(new Bullet(name, x, y, v));
            }

        }
    }
}