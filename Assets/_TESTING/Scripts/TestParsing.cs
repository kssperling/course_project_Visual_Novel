using System.Collections.Generic;
using DIALOGUE;
using TMPro;
using UnityEngine;

namespace TESTING
{
    public class TestParsing : MonoBehaviour
    {
        [SerializeField] private TextAsset file;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

            SendFiletoParse();

        }

        void SendFiletoParse()
        {
            List<string> lines = FileManager.ReadTextAsset("testFile");

            foreach (string line in lines)
            {
                if (line == string.Empty)
                {
                    continue;
                }
                DIALOGUE_LINE dl = DialogueParser.Parse(line);
            }
        }
    }
}
