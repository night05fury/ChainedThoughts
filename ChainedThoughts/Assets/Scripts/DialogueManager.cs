using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialgoueText;
    public Queue<string> sentences;
    
     void Start()
    {
        sentences = new Queue<string>();
    }
    public void StartDialogue (Dialogue dialogue)
    {
        Debug.Log("Starting the convo " + dialogue.name);

        nameText.text = dialogue.name;
        //sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            Debug.Log(sentences.Count);
            sentences.Enqueue(sentence);
            
        }
        DisplayNextSentence();

    }

    public void DisplayNextSentence()
    {
        Debug.Log(sentences.Count);
        int k = sentences.Count;
        if (k==0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
        dialgoueText.text = sentence;
    }

    void EndDialogue()
    {
        Debug.Log("End of Conversation");
    }
}
