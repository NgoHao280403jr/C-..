using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaHinhVaKeThua
{
    public abstract class Animal
    {
        public string Name;
        public Animal()         //constructor mặc định
        {
            Console.WriteLine("What is Animal? ");
        }
        public Animal(string Name) //Gán giá trị cho biến Name
        {
            this.Name = Name;
            Console.WriteLine("Animal...");
        }
        public virtual void Move()
        {
            Console.WriteLine("Con vat di chuyen ");
        }
        public void Sleep()
        {
            Console.WriteLine("Zzzz....Zzzzzz ");
        }
    }
    public class Cat : Animal
    {
        public int height;
        public int weight;
        /* Gọi đến constructor cua lop cha
         * Các biến của lớp cha sẽ được gán giá trị
         * sau đó mới đến các biến của lớp con*/
        public Cat(string Name, int height, int weight)
            : base(Name)
        {
            this.height = height;
            this.weight = weight;
            Console.WriteLine("- Cat(string,int,int)");
        }
        public Cat(int height, int weight)
            : base()   //constructor gọi đến constructor mặc định (ko tham số) của lớp cha
        {
            this.weight = weight;
            this.height = height;
            Console.WriteLine("- Cat(int,int)");
        }
        public void Say()
        {
            Console.WriteLine("Meo Meo");
        }
        public override void Move()
        {
            Console.WriteLine("Meo di chuyen");
        }
    }
    class Catest
    {
        static void Main()
        {
            Console.WriteLine("Tao mot con meo tu lop Cat(string,int,int)");
            Cat tom = new Cat("Di Hia", 30, 5);
            Console.WriteLine("..............");
            Console.WriteLine("Con meo ten la: {0}", tom.Name);
            Console.WriteLine("Nang: {0}kg", tom.weight);
            Console.WriteLine("Cao: {0}cm", tom.height);
            Console.WriteLine("..............");

            tom.Say();      //Gọi phương thức được kế thừa 
            tom.Sleep();
            tom.Move();

            Console.ReadLine();
        }
    }
}