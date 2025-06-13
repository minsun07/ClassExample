using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Program
    {
        class Parent
        {
            public static int counter = 0;
            public void CountParent()
            {
                Parent.counter++;
            }

            public Parent() {Console.WriteLine("Parent()");}
            public Parent(string name) {Console.WriteLine("Parent(string name)"); }
            public Parent(int param) { Console.WriteLine("Parent(int param)"); }


        }

        class Child : Parent  // :으로 상속 받음
        {
            public void CountChild()
            {
                Child.counter++;
            }
            public Child() : base("child")
            {
                Console.WriteLine("자식 생성자 A");
            }
            public Child(string name) : base(name)
            {
                Console.WriteLine("자식 생성자 B");
            }
            public Child(int param) : base(param)
            {
                Console.WriteLine("자식 생성자 C");
            }

        }

        public static int numer = 10;

        static void Main(string[] args)
        {

            //섀도잉
            int numbeer = 10;
            Console.WriteLine(numbeer);  // 클래스 변수이름이 가려짐(shadowing)
            Console.WriteLine(Program.numer);  // 호출하고 싶으면 클래스 변수명으로 사용


            //Child child = new Child();  // 객체(클래스) 생성
            Child childA = new Child("abc");
            Child childB = new Child(3);
            // int < long < float < double
            // 4      8      4         8

            Parent parent = new Parent();
            Child child = new Child();

            parent.CountParent();
            child.CountChild();

            Console.WriteLine(Parent.counter);
            Console.WriteLine(Child.counter);
        }

        
    }
}
