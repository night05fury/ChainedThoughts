using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MessageTrigger : MonoBehaviour
{
    public GameObject FlowerText;
    public GameObject Phone;
   public GameObject Diary;
   public GameObject Poster;
    public GameObject Photos;
    public GameObject Cat;
    public GameObject NextButton;
    public GameObject SuicideText;
    public GameObject FriendText;
    public GameObject BallText;

    public GameObject Classmate1;
    public GameObject Classmate2;
    public GameObject Classmate3;
    public GameObject Clock;
    public GameObject Window;
    public GameObject Book;
    //public static MessageTrigger instance;

    public static int Clicks=0;
    public static int pgcount=0;
    public static int clcount = 0;
    public void showText()
    {
        Clicks++;
       FlowerText.SetActive(true);
    }
    public void showTextPhone()
    {
        Clicks++;
        Phone.SetActive(true);
    }
    public void showTextDiary()
    {
        Clicks++;
        Diary.SetActive(true);
    }
    public void showTextPoster()
    {
        Clicks++;
        Poster.SetActive(true);
    }
    public void showTextPhotos()
    {
        Clicks++;
        Photos.SetActive(true);
    }
    public void ShowCatText()
    {
        Clicks++;
        Cat.SetActive(true);
    }
    public void ShowButton()
    {
        if(Clicks==6)
        {
            SuicideText.SetActive(true);
            NextButton.SetActive(true);

        }
        if(pgcount==2)
        {
            NextButton.SetActive(true);
        }
        if(clcount==6)
        {
            NextButton.SetActive(true);
        }
    }

    public void ShowFriendText()
    {
        FriendText.SetActive(true);
        pgcount++;
    }
    public void ShowBallText()
    {
        pgcount++;
        BallText.SetActive(true);
    }

    public void ShowClassmateText1()
    {

        Classmate1.SetActive(true);
        clcount++;
        
    }
    public void ShowClassmateText2()
    {

        
        Classmate2.SetActive(true);
        clcount++;
       
    }
    public void ShowClassmateText3()
    {


        Classmate3.SetActive(true);
        clcount++;

    }
    public void ShowWindowText()
    {
        Window.SetActive(true);
        clcount++;
    }
    public void ShowClockText()
    {
        clcount++;
        Clock.SetActive(true);
    }
    public void ShowBookText()
    {
        clcount++;
        Book.SetActive(true);
    }






}
