namespace PS
{
    public delegate void GreetinsDelegate(string name);
    ////////////////////////////////////////////////////////////////////////////////////////
    //class Player
    //{
    //    public string name {  get; set; }
    //    public int health { get; set; }
    //    //public Player(int health , string name)
    //    //{
    //    //    this.health = health;
    //    //    this.name = name;
    //    //}
    //    //public static Player operator +  (Player a,Player p)
    //    //{
    //    //    return new Player(a.health + p.health, a.name + " " + p.name);
    //    //}
    //    //public static Player operator ++  (Player a)
    //    //{
    //    //    return new Player( ++ a.health , a.name.ToUpper());
    //    //}
    //}
    ////////////////////////////////////////////////////////////////////////////////////////
    class Greetings
    { 
        public void SayHello(string name)
        {
            Console.WriteLine($"hello {name}");
        }
        public void SayWelcome(string name)
        {
            Console.WriteLine($"Welcome {name}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Greetings greetings = new Greetings();
            GreetinsDelegate del = greetings.SayHello;
            del("adham");
            del = greetings.SayWelcome;
            del("adham");
            ////////////////////////////////////////////////////////////////////////////////////////

            //    Player p1 = new Player(100, "Player 1");
            //    Player p2 = new Player(200, "Player 2");

            //    p1++;

            //    Player p3 = p1 + p2;

            //    Console.WriteLine(p3.name);
            //    Console.WriteLine(p3.health);
            ////////////////////////////////////////////////////////////////////////////////////////
            //Console.Write("Please enter the size of the array: ");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new int[size];
            //for (int i=0; i<numbers.Length;i++)
            //{
            //    Console.Write($"Enter the element number {i+1}: ");
            //    numbers[i]=Convert.ToInt32(Console.ReadLine());
            //}
            //int counter = 0;
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    counter = 0;
            //    for(int j = 0; j < numbers.Length; j++)
            //    {
            //        if (numbers[i] == numbers[j])
            //            counter++;
            //    }
            //    Console.WriteLine($"number {numbers[i]} appears {counter} times");
            //}
        }
    }
}
