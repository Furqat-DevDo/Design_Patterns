namespace Inheritance
{
    class Cat : Animals
    {
        public override void Sound()
        {
            Console.WriteLine("Cat is making sound");
        }
        public override void Eat()
        {
            Console.WriteLine("Cat is eating");
        }
        public override void Sleep()
        {
            Console.WriteLine("Cat is sleeping");
        }
        public override void Move()
        {
            Console.WriteLine("Cat is moving");
        }
    }
}