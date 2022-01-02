using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoadeer : MonoBehaviour
{
    GameObject showButton;
    public void PlayButton()
    {
        SceneManager.LoadScene("MAIN SCENE 1.1");
    }

    public void loadinstructionScene()
    {
        SceneManager.LoadScene("Instructions Scene");
    }
    public void BacktoMain()
    {
        SceneManager.LoadScene("MAIN SCENE");
    }
    public void LoadMain1_2()
        {
        SceneManager.LoadScene("MAIN SCENE 1.2");
        }
    public void LoadClassroom()
    {
        SceneManager.LoadScene("SCENE 2.1");
        int q = MessageTrigger.pgcount;  //z stores the count of the clicked items in the scene
        if (q == 6)
        {
            showButton.SetActive(true);

        }
    }
    public void LoadPlayGround()
    {
        SceneManager.LoadScene("PLAYGROUND 1.1");
        int z = MessageTrigger.pgcount;  //z stores the count of the clicked items in the scene
        if (z == 2)
        {
            showButton.SetActive(true);

        }
    }
    public void LoadBedRoom()
    {
        SceneManager.LoadScene("BEDROOM");
        int m = MessageTrigger.Clicks;
        if (m==6 )
        {
            showButton.SetActive(true);
          
        }
    }
    public void EndScene()
    {
       /* if (MessageTrigger.Clicks == 5)
        {
            showButton.SetActive(true);
            SceneManager.LoadScene("BEDROOM");
        }*/
        SceneManager.LoadScene("END");
    }

}
