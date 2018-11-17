using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        int[] array;
        int length, MAX;

        void Create(int max)
        {
            MAX = max;
            array = new int[MAX];
            print("array size :" + MAX + " is created\n");
        }
        void Puch(int val)
        {
            if (length < MAX)
            {                
                array[length++] = val;
            }
            else
            {
                print("array is full cannt push\n");
            }
        }
        void Pop()
        {
            if(length > 0)
            {
                array[--length] = -100000;
               // length--;
            }
            else
            {
                print("aray is empty cant Pop\n");
            }
        }
        void Update(int position , int newVal)
        {
            if(position >-1 && position <length)
                array[position] = newVal;
            else
            {
                print("position has wrong val :" + position);
            }
        }
        void Search(int x)
        {
            for(int i=0;i<length; i++)
            {
                if (array[i] == x)
                {
                    print(x + " on position " + i+"\n");
                }
            }
        }
        void print(string s)
        {
            Console.Write(s);
        }
        void printArray()
        {
            print("\n---------------\n");
            for (int i = 0; i < length; i++)
            {
                print(array[i] + " ");
            }
            print("\n---------------\n");
        }

        void Start()
        {
            print("To start");
        create:
            print(" please enter the array size ");
            int n = ReadInt();
            Create(n);
            print("enter number to push to the arry any letter to stop pushing\n");
            while (length < MAX)
            {
                try
                {
                    n = int.Parse(Console.ReadLine()); ;
                    Puch(n);
                }
                catch (Exception) { break; }
            }

            printArray();

            
            while (true)
            {
                menu:
                print("select\n1:push\n2: pop\n3: Update\n4: search\n5: print the array\n0: create new array\n");
                n = ReadInt();
                switch (n)
                {
                    case 1:print("enter the val to push ");
                        n = ReadInt();
                        Puch(n);
                        break;
                    case 2:
                        //print("enter the val to pop ");
                        //n = ReadInt();
                        Pop();
                        break;
                    case 3:print("enter the position and new val ");
                        Update(ReadInt(), ReadInt());
                        break;
                    case 4:print("search for? ");
                        Search(ReadInt());
                        break;
                    case 5:
                        printArray();
                        break;
                    case 0: goto create;
                    //default: goto menu;

                }
            }

        }
        int ReadInt()
        {
            a:
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                print("please enter corect int val");
                goto a;
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Start();

        }
    }
}
