using System.Collections.Generic;
using System;

enum Menu {
    Playgame = 1,
    Exit
}
namespace MTT
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenuScreen();
            
        }

        static void PrintMenuScreen() { 
            Console.Clear();
            PrintHeader();
            PrintListMenu();
            InputMenuFromKeyboard();
        }

        static void PrintHeader(){
            Console.WriteLine("Welcome to Hangman Game");
            Console.WriteLine("-----------------------");
        }

        static void PrintListMenu(){
            Console.WriteLine("1.Play game");
            Console.WriteLine("2.Exit");
        }

        static void InputMenuFromKeyboard(){
            Console.Write("Please Select Menu: ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu);
        }

        static void PresentMenu(Menu menu){
            if (menu == Menu.Playgame){
                ShowHangmanGameScreen();
            }
            else if (menu == Menu.Exit){
                ShowExitScreen();
            }else{
                
            }
        }

        static void ShowHangmanGameScreen(){
            Console.Clear();
            PrintHeaderHangmanGame();
        }

        static void PrintHeaderHangmanGame(){
            Console.WriteLine("Play Game Hangman");
            Console.WriteLine("--------------------");
            
            InCorrectcount();
            InputHangmanLetter();
            

        }

        static void InputHangmanLetter(){
           
           Console.Write("Input letter alphabet: {0} ");
        }
        static void InCorrectcount(){
            
            Console.WriteLine("Incorrect Score: 0 ");
        }


        static void ShowExitScreen(){
            Console.Clear();
            Console.WriteLine("Good luck!!");
            Console.ReadLine();
        }
    } 
}
