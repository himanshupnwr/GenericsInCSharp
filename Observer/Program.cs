using Observer;

class Program
{
    static void Main(string[] args)
    {
        var dog = new Dog();
        var observer = new BaseObserver<Dog>();
        dog.Attach(observer);
        observer.Notify = (subject) =>
        {
            if (subject.ObjectFound is Sprinkler)
            {
                subject.ObjectFound = null;
                return Reaction.BadDog;
            }

            return Reaction.GoodGirl;
        };
        while (true)
        {

            if (dog.ObjectFound is Sprinkler)
            {
                throw new Exception("Oh no the dog ate the sprinkler again!");
            }

            dog.Run();
            Thread.Sleep(new TimeSpan(0, 1, 0));
        }
    }
}