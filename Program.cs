using System.Dynamic;

namespace Factory
{
    public class Program
    {
        static void Main()
        {
            ClassFactory classFactory = new ClassFactory();

            AbstractClass obj1 = classFactory.CreateInstance(1);
            obj1.DoSomething();

            AbstractClass obj2 = classFactory.CreateInstance(2);
            obj2.DoSomething();

            AbstractClass obj3 = classFactory.CreateInstance(3);
            obj3.DoSomething();
        }
    }

    public class ClassFactory
    {
        public AbstractClass CreateInstance(int id)
        {
            AbstractClass result = id switch
            {
                1 => new Class1(),
                2 => new Class2(),
                3 => new Class3(),
                _ => throw new ArgumentException()
            };

            return result;
        }
    }

    public abstract class AbstractClass
    { 
        public abstract void DoSomething();
    }

    public class Class1 : AbstractClass
    {
        internal Class1()
        {

        }

        public override void DoSomething()
        {
            Console.WriteLine("Class 1");
        }
    }

    public class Class2 : AbstractClass
    {
        internal Class2()
        {

        }

        public override void DoSomething()
        {
            Console.WriteLine("Class 2");
        }
    }

    public class Class3 : AbstractClass
    {
        internal Class3()
        {

        }

        public override void DoSomething()
        {
            Console.WriteLine("Class 3");
        }
    }
}
