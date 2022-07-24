namespace Inheritance
{
    class Horse : Animals
    {
        public override void Sound()
        {
            Console.WriteLine("Horse is making sound");
        }
        public override void Eat()
        {
            Console.WriteLine("Horse is eating");
        }
        public override void Sleep()
        {
            Console.WriteLine("Horse is sleeping");
        }
        public override void Move()
        {
            Console.WriteLine("Horse is moving");
        }
    }
}