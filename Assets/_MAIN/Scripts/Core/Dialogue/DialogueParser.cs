using System.Text.RegularExpressions;
using UnityEngine;

namespace DIALOGUE
{
    public class DialogueParser
    {
        //создаем паттерн
        private const string commandRegexPattern = @"[\w\[\]]*[^\s]\(";
        public static DIALOGUE_LINE Parse(string rawLine)
        {
            // Debug.Log($"Parsing Line - '{rawLine}'");

            (string speaker, string dialogue, string commands) = RipContent(rawLine);
            
            // Debug.Log($"Speaker = '{speaker}'\nDialogue = '{dialogue}'\nCommands = '{commands}'");
            
            return new DIALOGUE_LINE(speaker, dialogue, commands);
        }

        private static (string, string, string) RipContent(string rawLine)
        {
            string speaker = "", dialogue = "", commands = "";

            int dialogueStart = -1;
            int dialogueEnd = -1;
            bool isEscaped = false;

            for (int i = 0; i < rawLine.Length; i++)
            {
                char current = rawLine[i];
                if (current == '\\') {
                    isEscaped = !isEscaped;
                } else if (current == '"' && !isEscaped) {
                    if (dialogueStart == -1)
                    {
                        dialogueStart = i;
                    } else if (dialogueEnd == -1)
                    {
                        dialogueEnd = i;
                    }
                }
                else
                {
                    isEscaped = false;
                }
            }
            
            //идентифицируем командный паттерн
            Regex commandRegex = new Regex(commandRegexPattern);
            MatchCollection matches = commandRegex.Matches(rawLine);
            int commandStart = -1;
            foreach (Match match in matches)
            {
                if (match.Index < dialogueStart || match.Index > dialogueEnd)
                {
                    commandStart = match.Index;
                    break;
                }
            }

            if (commandStart != -1 && (dialogueStart == -1 && dialogueEnd == -1))
            {
                return ("", "", rawLine.Trim());
            }
            
            
            // если мы здесь, то это значит, что у нас либо есть диалог, либо несколько слов в аргументе команды.
            // рассмотрим, если есть диалог
            if (dialogueStart != -1 && dialogueEnd != -1 && (commandStart == -1 || commandStart > dialogueEnd))
            {
                // мы знаем, что у нас есть диалог
                speaker = rawLine.Substring(0, dialogueStart).Trim();
                dialogue = rawLine.Substring(dialogueStart + 1, dialogueEnd - dialogueStart - 1).Replace("\\\"", "\"");
                if (commandStart != -1)
                {
                    commands = rawLine.Substring(commandStart).Trim();
                }
            } else if (commandStart != -1 && dialogueStart > commandStart)
            {
                commands = rawLine;
            } else
            {
                dialogue = rawLine;
            }
            
            return (speaker, dialogue, commands);
        }
    }
}
