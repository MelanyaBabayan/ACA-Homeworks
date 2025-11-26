namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Number 1
            Message msg;
            msg = new ErrorMessage();
            msg.Print();
            msg = new SuccessMessage();
            msg.Print();

            //Number 2
            Animal[] animals = new Animal[3];
            animals[0] = new Dog("Rex");
            animals[1] = new Cat("Luna");
            animals[2] = new Cow("Tsaghik");
            foreach (Animal animal in animals)
            {
                if (animal != null)
                {
                    Console.Write($"{animal.GetName()}: ");
                    animal.Speak();
                }
            }
        }
    }
}
