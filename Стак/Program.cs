using System.ComponentModel.Design;

namespace Стак
{

public class StakeItem<T>
    {
        public StakeItem<T> Previous {  get; set; }
        public T Value { get; set; }
    }

    public class MyStake<T>
    {
        private StakeItem<T> obj;

        public void Push(T value)
        {
            StakeItem<T> newItem = new StakeItem<T>
            {
                Value = value,
                Previous = obj
            };
            obj = newItem;
        }

        public T Pop()
        {
            if (obj == null)
            {
                return default(T);
            }
            T value = obj.Value;
            obj = obj.Previous;
            return value;
        }
        public T Peek()
        {
            if (obj == null)
            {
                return default(T);
            }
            return obj.Value;

        }
        public int Count
        {
            get
            {
                int count = 0;
                StakeItem<T> current = obj;
                while (current != null)
                {
                    count++;
                    current = current.Previous;
                }
                return count;
            }
        }

        public void Clear()
        {
            obj = null;
        }



    }

class Program
    {
        public static void Main()
        {
            MyStake<Student> MyStack1 = new MyStake<Student>();
            Student student1 = new Student();
            student1.FirstName = Console.ReadLine();
            student1.LastName = Console.ReadLine();
            MyStack1.Push(student1);
            Student student2 = new Student();
            student2.FirstName = Console.ReadLine();
            student2.LastName = Console.ReadLine();
            MyStack1.Push(student2);
            Student student3 = new Student();
            student3.FirstName = Console.ReadLine();
            student3.LastName = Console.ReadLine();
            MyStack1.Push(student3);
            Student student4 = new Student();
            student4.FirstName = Console.ReadLine();
            student4.LastName = Console.ReadLine();
            MyStack1.Push(student4);
            Student student5 = new Student();
            student5.FirstName = Console.ReadLine();
            student5.LastName = Console.ReadLine();
            MyStack1.Push(student5);

            MyStake<Student> MyStack2 = new MyStake<Student>();
            do
            {
                var students = MyStack1.Pop();
                if (students == null)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Оценка для этого студента?");
                    students.Mark = Console.ReadLine();

                    MyStack2.Push(students);
                    Console.WriteLine(students);

                }
            } while (true);
             



        }
    }




}