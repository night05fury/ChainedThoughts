using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class States : ScriptableObject
{
    // creating a state file to load the Texts
    [SerializeField] string GameText;
    [SerializeField] States[] otherStates;
    // Start is called before the first frame update
    public string GetStateText()
    {
        return GameText;
    }
    public States[] GetOtherStates()
    {
        return otherStates;
    }
}
