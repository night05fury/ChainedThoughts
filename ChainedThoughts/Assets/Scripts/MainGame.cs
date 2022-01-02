/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGame : MonoBehaviour
{
    [SerializeField] Text textElement;
    [SerializeField] States startState;
    States state;
    // Start is called before the first frame update
    void Start()
    {
        state = startState;
        textElement.text = state.GetStateText();

    }

    // Update is called once per frame
    void Update()
    {
        GameMain();
    }
    private void GameMain()
        {
        States[] statesArray = state.GetOtherStates();
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            state = statesArray[0];
        }
       else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            state = statesArray[1];
        }
        textElement.text = state.GetStateText();
    }
}
*/