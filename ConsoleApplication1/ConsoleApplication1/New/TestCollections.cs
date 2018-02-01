using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.New
{
    class TestCollections
    {
        static public void ShowTestColection()
        {
            ArrayList list = new ArrayList();
            list.Add(2.3); // заносим в список объект типа double
            list.Add(55); // заносим в список объект типа int
            list.AddRange(new string[] {"Hello", "world"}); // заносим в список строковый массив

            // перебор значений
            foreach (object o in list)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("----------");
            // удаляем первый элемент
            list.RemoveAt(0);
            // переворачиваем список
            list.Reverse();
            // получение элемента по индексу
            Console.WriteLine(list[0]);
            // перебор значений
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

        }
    }

    class CollectClass
    {
        public static void ShowQueu()
        {
            Queue<int> numbers = new Queue<int>();

            numbers.Enqueue(3); // очередь 3
            numbers.Enqueue(5); // очередь 3, 5
            numbers.Enqueue(8); // очередь 3, 5, 8

            // получаем первый элемент очереди
            int queueElement = numbers.Dequeue(); //теперь очередь 5, 8
            Console.WriteLine(queueElement);

            Queue<Pers> persons = new Queue<Pers>();
            persons.Enqueue(new Pers() { Name = "Tom" });
            persons.Enqueue(new Pers() { Name = "Bill" });
            persons.Enqueue(new Pers() { Name = "John" });

            // получаем первый элемент без его извлечения
            Pers pp = persons.Peek();
            Console.WriteLine(pp.Name);

            Console.WriteLine("Сейчас в очереди {0} человек", persons.Count);

            // теперь в очереди Tom, Bill, John
            foreach (Pers p in persons)
            {
                Console.WriteLine(p.Name);
            }

            // Извлекаем первый элемент в очереди - Tom
            Pers person = persons.Dequeue(); // теперь в очереди Bill, John
            Console.WriteLine(person.Name);

            Console.ReadLine();
        }

        public static void ShowDictionary()
        {

            Console.WriteLine("Part1");
            Dictionary<int, object> testDictionary = new Dictionary<int, object>();
            testDictionary.Add(1, "asdas");
            testDictionary.Add(2,12);
            testDictionary.Add(3,11.3);
            testDictionary.Add(4,'a');

          
            Console.WriteLine($"Count = {testDictionary.Count}");
            Console.WriteLine($"First = {testDictionary.First()}, last = {testDictionary.Last()}");
            var varr = testDictionary.Values;
            Console.WriteLine($"{varr}");
            var var2 = testDictionary[2];
            Console.WriteLine($"Value = {var2}, type {var2.GetType()} ");



            Console.WriteLine("Part2");
            Dictionary<char, Pers> people = new Dictionary<char, Pers>();
            people.Add('b', new Pers() { Name = "Bill" });
            people.Add('t', new Pers() { Name = "Tom" });
            people.Add('j', new Pers() { Name = "John" });

            foreach (KeyValuePair<char, Pers> keyValue in people)
            {
                // keyValue.Value представляет класс Person
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value.Name);
            }

            // перебор ключей
            foreach (char c in people.Keys)
            {
                Console.WriteLine(c);
            }

            // перебор по значениям
            foreach (Pers p in people.Values)
            {
                Console.WriteLine(p.Name);
            }

            Console.WriteLine("\nPart3");
            //Инициализация словарей
            Dictionary<string, string> countries1 = new Dictionary<string, string>
            {
                {"Франция", "Париж"},
                {"Германия", "Берлин"},
                {"Великобритания", "Лондон"}
            };

            foreach (var pair in countries1)
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);

            Dictionary<string, string> countries2 = new Dictionary<string, string>
            {
                ["Франция"] = "Париж",
                ["Германия"] = "Берлин",
                ["Великобритания"] = "Лондон"
            };

        }

        public static void ShowStack()
        {
          

                Stack<int> numbers = new Stack<int>();

                numbers.Push(3); // в стеке 3
                numbers.Push(5); // в стеке 5, 3
                numbers.Push(8); // в стеке 8, 5, 3

                // так как вверху стека будет находиться число 8, то оно и извлекается
                int stackElement = numbers.Pop(); // в стеке 5, 3
                Console.WriteLine(stackElement);

                Stack<Pers> persons = new Stack<Pers>();
                persons.Push(new Pers() { Name = "Tom" });
                persons.Push(new Pers() { Name = "Bill" });
                persons.Push(new Pers() { Name = "John" });

                foreach (Pers p in persons)
                {
                    Console.WriteLine(p.Name);
                }

                // Первый элемент в стеке
                Pers person = persons.Pop(); // теперь в стеке Bill, Tom
                Console.WriteLine(person.Name);

                Console.ReadLine();
            
        }
        

    }

    class Pers
    {
        public string Name { get; set; }
    }


}