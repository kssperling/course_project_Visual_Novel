using System;
using System.Collections;
using System.Collections.Generic;
using COMMANDS;
using NUnit.Framework.Internal.Filters;
using Unity.VisualScripting;
using UnityEngine;

namespace TESTING
{
    public class CMD_DatabaseExtensions_Examples : CMD_DatabaseExtension
    {
        new public static void Extend(CommandDatabase database)
        {
            //Добавляем команды без параметров
            database.AddCommand("print", new Action(PrintDefaultMessage));
            database.AddCommand("print_1p", new Action<string>(PrintUsermessage));
            database.AddCommand("print_mp", new Action<string[]>(PrintLines));
            
            //Добавляем лямбду без параметров
            database.AddCommand("lambda", new Action(() => { Debug.Log("Printing a default message to console form lambds command."); }));
            database.AddCommand("lambda_1p", new Action<string>((arg) => { Debug.Log($"User lambda message: '{arg}'"); }));
            database.AddCommand("lambda_mp", new Action<string[]>((args) => { Debug.Log(String.Join(", ", args)); }));
            
            //Запускаем процессы без параметров
            database.AddCommand("process", new Func<IEnumerator>(SimpleProcess));
            database.AddCommand("process_1p", new Func<string, IEnumerator>(LineProcess));
            database.AddCommand("process_mp", new Func<string[], IEnumerator>(MultiLineProcess));
            
            //Особый пример
            database.AddCommand("moveCharDemo", new Func<string, IEnumerator>(MoveCharacter));
        }

        private static void PrintDefaultMessage()
        {
            Debug.Log("Printing a default message to console.");
        }

        private static void PrintUsermessage(string message)
        {
            Debug.Log($"User message: '{message}'");
        }

        private static void PrintLines(string[] lines)
        {
            int i = 1;
            foreach (string line in lines)
            {
                Debug.Log($"{i++}. '{line}'");
            }
        }

        private static IEnumerator SimpleProcess()
        {
            for (int i = 0; i < 5; i++)
            {
                Debug.Log($"Simple process: {i}");
                yield return new WaitForSeconds(1);
            }
        }
        
        private static IEnumerator LineProcess(string data)
        {
            if (int.TryParse(data, out int num))
            {
                for (int i = 0; i < 5; i++)
                {
                    Debug.Log($"Simple process: {i}");
                    yield return new WaitForSeconds(1);
                }
            }
        }
        
        private static IEnumerator MultiLineProcess(string[] data)
        {
            foreach (string line in data)
            {  Debug.Log($"process message: {line}");
                yield return new WaitForSeconds(0.5f);
            }
        }

        private static IEnumerator MoveCharacter(string direction)
        {
            bool left = direction.ToLower() == "left";
            
            Transform character = GameObject.Find("Image").transform;
            float moveSpeed = 15;


            float targetX = left ? -8 : 8;
            
            float currentX = character.position.x;

            while (Mathf.Abs(targetX - currentX) > 0.1f)
            {
                // Debug.Log($"Moving to {(left ? "lest" : "right")} [{currentX/targetX}]");
                currentX = Mathf.MoveTowards(currentX, targetX, moveSpeed * Time.deltaTime);
                character.position = new Vector3(currentX, character.position.y, character.position.z);
                yield return null;
            }
        }
    }

}