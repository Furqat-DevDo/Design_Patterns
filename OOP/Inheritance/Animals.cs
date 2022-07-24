namespace Inheritance
{
    class Animals
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public virtual void Sound()
        {
            Console.WriteLine("Animal is making sound");
        }
        public virtual void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
        public virtual void Sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }

        public virtual void Move()
        {
            Console.WriteLine("Animal is moving");
        }

        public bool Is_Alive { get; set; }
    }
}