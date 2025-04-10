using UnityEngine;
using DIALOGUE;
namespace TESTING
{
    public class Testing_Architect : MonoBehaviour
    {
        DialogueSystem ds;
        TextArchitect architect;

        public TextArchitect.BuildMethod bm = TextArchitect.BuildMethod.instant;

        string[] lines =
        {
            "hiiiiiiiiii",
            "meow",
            "alina, hi",
            "i love you",
            "meomewomeomeomeowmeow!!!!!!"
        };
        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            ds = DialogueSystem.instance;
            architect = new TextArchitect(ds.dialogueContainer.dialogueText);
            architect.buildMethod = TextArchitect.BuildMethod.fade;
            architect.speed = 0.2f;
        }

        // Update is called once per frame
        void Update()
        {
            if (bm != architect.buildMethod)
            {
                architect.buildMethod = bm;
                architect.Stop();
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                architect.Stop();
            }
            
            string longline = "hvuhsdgpkpipipippippiipkipkipikpikipkipkipikpikpikipkipkipkipikpikpikpi";
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (architect.isBuilding)
                {
                    if (!architect.hurryUp)
                    {
                        architect.hurryUp = true;
                    }
                    else
                    {
                        architect.ForceComplete();
                    }
                }
                else
                {
                    architect.Build(longline);
                    // architect.Build(lines[Random.Range(0, lines.Length)]);
                }
            } 
            else if (Input.GetKeyDown(KeyCode.A)) 
            {
                architect.Append(longline);
                // architect.Append(lines[Random.Range(0, lines.Length)]);
            }
        }
    }
}
