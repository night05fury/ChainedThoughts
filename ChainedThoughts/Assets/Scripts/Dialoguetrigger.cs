using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialoguetrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public void Trigger()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

}
