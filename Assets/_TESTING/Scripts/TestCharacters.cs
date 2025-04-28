using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CHARACTERS;
using DIALOGUE;
using NUnit.Framework.Internal;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Analytics;

namespace TESTING
{
    public class TestCharacters : MonoBehaviour
    {

        public TMP_FontAsset tempFont;
        
        private Character CreateCharacter(string name) => CharacterManager.instance.CreateCharacter(name);
        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        { 
            //Character Raelin = CharacterManager.instance.CreateCharacter("Raelin");
            //Character fs2 = CharacterManager.instance.CreateCharacter("Female Student 2");
            // Character Stella = CharacterManager.instance.CreateCharacter("Stella");
            // Character Stella2 = CharacterManager.instance.CreateCharacter("Stella");
            // Character Adam = CharacterManager.instance.CreateCharacter("Adam");
            StartCoroutine(Test_3D_Characters());
        }

        IEnumerator Test()
        {
            // Character guard1 = CreateCharacter("Guard1 as Generic");
            // Character_Sprite guard2 = CreateCharacter("Guard2 as Raelin") as Character_Sprite;
            // Character guard3 = CreateCharacter("Guard3 as Female Student 2");
            //
            // guard1.SetPosition(Vector2.zero);
            // guard2.SetPosition(new Vector2(0.5f, 0.5f));
            // guard3.SetPosition(Vector2.one);
            //
            // Sprite bodySprite = guard2.GetSprite("Raelin_2");
            // Sprite faceSprite = guard2.GetSprite("Raelin_15");
            //
            // guard2.SetSprite(bodySprite, 0);
            // guard2.SetSprite(faceSprite, 1);
            //
            // guard2.Show();
            // guard3.Show();
            //
            // yield return guard1.Show();
            //
            // yield return guard1.MoveToPosition(Vector2.one, smooth: true);
            // yield return guard1.MoveToPosition(Vector2.zero, smooth: true);
            //
            //
            // guard1.SetDialogueFont(tempFont);
            // guard1.SetNameFont(tempFont);
            // guard2.SetDialogueColor(Color.cyan);
            // guard3.SetNameColor(Color.red);
            //
            // yield return guard1.Say("meowmeowmeow");
            // yield return guard2.Say("pipipipipipip");
            // yield return guard3.Say("lsallalalaallal");
            
            
            // Character_Sprite Raelin = CreateCharacter("Raelin") as Character_Sprite;
            // //Character_Sprite Guard = CreateCharacter("Guard as Generic") as Character_Sprite;
            // //Raelin.isVisible = true;
            // yield return new WaitForSeconds(1);
            //
            // //Sprite body = Raelin.GetSprite("Raelin_1");
            // //Sprite face = Raelin.GetSprite("Raelin_15");
            // //Raelin.SetSprite(body);
            // //yield return Raelin.TransitionSprite(face, 1);
            //
            // yield return new WaitForSeconds(1);
            //
            //
            // yield return Raelin.Flip();
            //
            //
            // yield return Raelin.FaceLeft();
            //
            //
            //
            // yield return Raelin.UnHighlight();
            // yield return new WaitForSeconds(1);
            // yield return Raelin.TransitionColor(Color.red);
            // yield return new WaitForSeconds(1);
            // yield return Raelin.Highlight();
            // yield return new WaitForSeconds(1);
            // yield return Raelin.TransitionColor(Color.white);
            //
            // //Raelin.TransitionSprite(Raelin.GetSprite("Raelin_7"), 1, 0.3f);
            //
            // //Raelin.MoveToPosition(Vector2.zero, smooth:true);
            
            
             
            
            
            
            
            // Character_Sprite Raelin = CreateCharacter("Raelin") as Character_Sprite;
            //
            // Character_Live2D Mao = CreateCharacter("Mao") as Character_Live2D;
            //
            // Raelin.SetPosition(new Vector2(0, 0));
            // Mao.SetPosition(new Vector2(1, 0));
            //
            // yield return new WaitForSeconds(1);
            //
            // Mao.SetMotion("Healing Heart");
            //
            // yield return new WaitForSeconds(1);
            //
            // Mao.SetExpression("shocked");
            
            
            
            // Character_Sprite Raelin = CreateCharacter("Raelin") as Character_Sprite;
            //
            // Character_Live2D Mao = CreateCharacter("Mao") as Character_Live2D;
            //
            // Raelin.SetPosition(new Vector2(0, 0));
            // Mao.SetPosition(new Vector2(1, 0));
            //
            // yield return new WaitForSeconds(1);
            //
            // Raelin.FaceRight();
            // Mao.FaceRight();
            //
            // yield return new WaitForSeconds(0.5f);
            //
            // Raelin.Flip();
            // Mao.Flip();
            
            // Mao.SetMotion("Healing Heart");
            
            // yield return new WaitForSeconds(1);
            //
            // Mao.SetExpression("shocked");
            
            // yield return new WaitForSeconds(1);
            // Mao.Hide();
            //
            // yield return new WaitForSeconds(1);
            // Mao.Show();
            //
            // yield return new WaitForSeconds(1);
            // Mao.TransitionColor(Color.red);
            //
            // yield return new WaitForSeconds(1);
            // Mao.TransitionColor(Color.white);
            
            // yield return new WaitForSeconds(1);
            // Mao.Show();
            
            // yield return new WaitForSeconds(1);
            // Mao.FaceDirection(false, 0.3f, false);
            //
            // yield return new WaitForSeconds(1);
            // Mao.FaceDirection(true, 0.3f, false);
            
            // yield return new WaitForSeconds(1);
            // Mao.FaceRight();
            //
            // yield return new WaitForSeconds(1);
            // Mao.Flip();
            //
            // yield return new WaitForSeconds(1);
            // Mao.Highlight();
            //
            // yield return new WaitForSeconds(1);
            // Mao.UnHighlight();
            //
            // yield return new WaitForSeconds(1);
            // Mao.Highlight();

            
            
            
            
            
            
            
            
            
            

            yield return null;
        }

        IEnumerator Test_3D_Characters()
        {
            // Character_Sprite Raelin = CreateCharacter("Raelin") as Character_Sprite;
            // Character_Live2D Mao = CreateCharacter("Mao") as Character_Live2D;
            // Character_Model3D Yae = CreateCharacter("Yae Miko") as Character_Model3D;
            //
            // Raelin.SetPosition(new Vector2(0, 0));
            // Mao.SetPosition(new Vector2(0.5f, 0));
            // // Yae.SetPosition(new Vector2(1, 0));
            //
            // yield return new WaitForSeconds(1);
            //
            // Raelin.TransitionColor(Color.red, 0.1f);
            // Mao.TransitionColor(Color.red, 0.1f); 
            // Yae.TransitionColor(Color.red, 0.1f);
            //
            // yield return new WaitForSeconds(2f);
            //
            // Raelin.UnHighlight();
            // Mao.UnHighlight();
            // Yae.UnHighlight();
            //
            // yield return new WaitForSeconds(2f);
            // Raelin.Highlight();
            // Mao.Highlight();
            // Yae.Highlight();

            yield return null;

        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
