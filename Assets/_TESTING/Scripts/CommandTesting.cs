using System.Collections;
using System.Collections.Generic;
using COMMANDS;
using Unity.VisualScripting;
using UnityEngine;

namespace TESTING
{
    public class CommandTesting : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            StartCoroutine(Running());
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                CommandManager.instance.Execute("moveCharDemo", "left");
            } else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                CommandManager.instance.Execute("moveCharDemo", "right");
            }
        }

        IEnumerator Running()
        {
            yield return CommandManager.instance.Execute("print");
            yield return CommandManager.instance.Execute("print_1p", "Hello World");
            yield return CommandManager.instance.Execute("print_mp", "Line1", "Line2", "Line3");
        
            yield return CommandManager.instance.Execute("lambda");
            yield return CommandManager.instance.Execute("lambda_1p", "Hello lambda");
            yield return CommandManager.instance.Execute("lambda_mp", "lambda1", "lambda2", "lambda3");
        
            yield return CommandManager.instance.Execute("process");
            yield return CommandManager.instance.Execute("process_1p", "Hello process");
            yield return CommandManager.instance.Execute("process_mp", "process1", "process2", "process3");
        }
    }

}