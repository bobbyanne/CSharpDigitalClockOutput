using System;
using System.Collections.Generic;

namespace challenges {
    class Program {

        static void top(int columnFromRight) {
            for (int i = columnFromRight; i < columnFromRight + 3; i++) {
                Console.SetCursorPosition(i, 0);
                Console.WriteLine(" ");
            }
        }

        static void topRight(int columnFromRight) {
            for (int i = 0; i < 3; i++) {
                Console.SetCursorPosition(columnFromRight + 2, i);
                Console.WriteLine(" ");
            }
        }

        static void topLeft(int columnFromRight) {
            for (int i = 0; i < 3; i++) {
                Console.SetCursorPosition(columnFromRight, i);
                Console.WriteLine(" ");
            }
        }

        static void middle(int columnFromRight) {
            for (int i = columnFromRight; i < columnFromRight + 3; i++) {
                Console.SetCursorPosition(i, 3);
                Console.WriteLine(" ");
            }
        }

        static void bottomRight(int columnFromRight) {
            for (int i = 3; i < 7; i++) {
                Console.SetCursorPosition(columnFromRight + 2, i);
                Console.WriteLine(" ");
            }
        }

        static void bottomLeft(int columnFromRight) {
            for (int i = 3; i < 7; i++) {
                Console.SetCursorPosition(columnFromRight, i);
                Console.WriteLine(" ");
            }
        }

        static void bottom(int columnFromRight) {
            for (int i = columnFromRight; i < columnFromRight + 3; i++) {
                Console.SetCursorPosition(i, 6);
                Console.WriteLine(" ");
            }
        }

        static void Colon(int columnFromRight) {
            Console.SetCursorPosition(columnFromRight + 1, 2);
            Console.WriteLine(" ");
            Console.SetCursorPosition(columnFromRight + 1, 5);
            Console.WriteLine(" ");
        }

        static void Digitize(int characterPos, char num) {
            int pos = characterPos * 4;

            switch (num)
            {
                case '0':
                    top(pos);
                    topRight(pos);
                    topLeft(pos);
                    bottom(pos);
                    bottomLeft(pos);
                    bottomRight(pos);
                    break;
                case '1':
                    topRight(pos);
                    bottomRight(pos);
                    break;
                case '2':
                    top(pos);
                    topRight(pos);
                    middle(pos);
                    bottomLeft(pos);
                    bottom(pos);
                    break;
                case '3':
                    top(pos);
                    topRight(pos);
                    middle(pos);
                    bottomRight(pos);
                    bottom(pos);
                    break;
                case '4':
                    topLeft(pos);
                    middle(pos);
                    topRight(pos);
                    bottomRight(pos);
                    break;
                case '5':
                    top(pos);
                    topLeft(pos);
                    middle(pos);
                    bottomRight(pos);
                    bottom(pos);
                    break;
                case '6':
                    top(pos);
                    topLeft(pos);
                    bottomLeft(pos);
                    bottomRight(pos);
                    bottom(pos);
                    middle(pos);
                    break;
                case '7':
                    top(pos);
                    topRight(pos);
                    bottomRight(pos);
                    break;
                case '8':
                    top(pos);
                    topRight(pos);
                    bottomRight(pos);
                    bottom(pos);
                    bottomLeft(pos);
                    topLeft(pos);
                    middle(pos);
                    break;
                case '9':
                    top(pos);
                    topRight(pos);
                    bottomRight(pos);
                    bottom(pos);
                    middle(pos);
                    topLeft(pos);
                    break;
                case ':':
                    Colon(pos);
                    break;
            }
        }

        static void Main (string[] args) {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;

            string time = "15:22:10";
            for (int i = 0; i < time.Length; i++)
            {
                Digitize(i, time[i]);
            }

            Console.ReadLine();
        }
    }
}