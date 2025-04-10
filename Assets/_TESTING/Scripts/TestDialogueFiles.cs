using System.Collections.Generic;
using DIALOGUE;
using UnityEngine;

public class TestDialogueFiles : MonoBehaviour
{
    // [SerializeField] private TextAsset file;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    [SerializeField] private TextAsset fileToRead = null;
    void Start()
    {

        StartConversation();

    }

    void StartConversation()
    {
        List<string> lines = FileManager.ReadTextAsset(fileToRead);
        
        // for (int i = 0; i < lines.Count; i++)
        // {
        //     string line = lines[i];
        //
        //     if (string.IsNullOrWhiteSpace(line))
        //         continue;
        //     
        //     DIALOGUE_LINE dl = DialogueParser.Parse(line);
        //     Debug.Log($"{dl.speaker.name} as [{(dl.speaker.castName != string.Empty ? dl.speaker.castName : dl.speaker.name)}] at {dl.speaker.castPosition}");
        //
        //     List<(int l, string ex)> expr = dl.speaker.CastExpressions;
        //     for (int c = 0; c < expr.Count; c++)
        //     {
        //         Debug.Log($"Layers[{expr[c].l}] = '{expr[c].ex}'");
        //     }
        // }

        // foreach (string line in lines)
        // {
        //     if (string.IsNullOrWhiteSpace(line))
        //     {
        //         continue;
        //     }
        //     
        //     DIALOGUE_LINE dl = DialogueParser.Parse(line);
        //
        //     for (int i = 0; i < dl.commandData.commands.Count; i++)
        //     {
        //         DL_COMMAND_DATA.Command command = dl.commandData.commands[i];
        //         Debug.Log($"Command [{i}] '{command.name}' has arguments [{string.Join(", ", command.arguments)}]");
        //     }
            // if (string.IsNullOrEmpty(line))
            // {
            //     continue;
            // }
            // Debug.Log($"Segmenting line '{line}'");
            // DIALOGUE_LINE dlLine = DialogueParser.Parse(line);
            //
            // int i = 0;
            // foreach (DL_DIALOGUE_DATA.DIALOGUE_SEGMENT segment in dlLine.dialogue.segments)
            // {
            //     Debug.Log($"Segment [{i++}] = '{segment.dialogue}' [signal={segment.startSignal.ToString()}{(segment.signalDelay > 0? $" {segment.signalDelay}" : $"")}]");
            // }
        // }
        
        DialogueSystem.instance.Say(lines);
    }
}
