using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Dialogue
{
    public string name;
    [TextArea (3,12)]
    public string[] sentences;
}
