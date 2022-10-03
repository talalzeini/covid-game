using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FallAutoLayout : MonoBehaviour
{
    public Transform scorePosition;

    public Transform scoreLose;

    public Transform CovidFreeTitle;

    public Transform AdsButton;

    public Transform pausePosition;

    public Transform fight00;
    public Transform fight01;

    public Transform tapToStart;

    public Transform Infected;

    public Transform Corona1;


    public Transform Corona2;
    public Transform Corona3;
    public Transform Corona4;
    public Transform Corona5;

      public Text tapStartText;

      public Text tryAgainText;

      public Text menuText;

      public Transform MenuButton;

      public Transform loseBest;
      public Transform newLoseBest;

      public Transform yesButton;

      public Transform noButton;

      public Transform resumeButton;

      public Transform fightPaused;

      public Transform pausedBest;

      public Text menuTextPaused;

      public Text tryAgainPaused;

      public Transform menuButtonPaused;

      

     void Update(){
        

        if(Screen.width == 1125 && Screen.height == 2436){ // Iphone XS
            scorePosition.position = new Vector2 ((Screen.width-Screen.width)+150, (Screen.height)-150);
            scorePosition.localScale = new Vector2(3*transform.localScale.x/2, 3*transform.localScale.y/2);
            scoreLose.position = new Vector2 ((Screen.width-Screen.width)+150, (Screen.height)-150);
            scoreLose.localScale = new Vector2(3*transform.localScale.x/2, 3*transform.localScale.y/2);
            scorePosition.localScale = new Vector2(3*transform.localScale.x/2, 3*transform.localScale.y/2);
            pausePosition.position = new Vector2 ((Screen.width)-125, (Screen.height)-142);
            pausePosition.localScale = new Vector2(3*transform.localScale.x/2, 3*transform.localScale.y/2);
            resumeButton.position = new Vector2 ((Screen.width)-125, (Screen.height)-142);
            resumeButton.localScale = new Vector2(3*transform.localScale.x/2, 3*transform.localScale.y/2);
            AdsButton.position = new Vector2 ((Screen.width)-125, (Screen.height)-142);
            AdsButton.localScale = new Vector2(3*transform.localScale.x/2, 3*transform.localScale.y/2);
            fight00.position = new Vector2((Screen.width/2), (Screen.height)-550);
            fight01.position = new Vector2((Screen.width/2), (Screen.height)-550);
            fight00.localScale = new Vector2(3*transform.localScale.x/2, 3*transform.localScale.y/2);
            fight01.localScale =new Vector2(3*transform.localScale.x/2, 3*transform.localScale.y/2);
            fightPaused.position = new Vector2((Screen.width/2), (Screen.height)-550);
            fightPaused.localScale =new Vector2(3*transform.localScale.x/2, 3*transform.localScale.y/2);
            Infected.position = new Vector2((Screen.width/2), (Screen.height)-550);
            Infected.localScale =new Vector2(3*transform.localScale.x/2, 3*transform.localScale.y/2);
            CovidFreeTitle.position = new Vector2((Screen.width/2), (Screen.height)-550);
            CovidFreeTitle.localScale =new Vector2(3*transform.localScale.x/2, 3*transform.localScale.y/2);
            tapToStart.position = new Vector2((Screen.width/2), (Screen.height/2)-715);
            tapStartText.fontSize = 60;
            tryAgainText.fontSize = 120;
            menuText.fontSize = 120;
            tryAgainPaused.fontSize = 120;
            menuTextPaused.fontSize = 120;
            menuButtonPaused.position = new Vector2 ((Screen.width/2), (Screen.height/2)-225);
            MenuButton.position = new Vector2 ((Screen.width/2), (Screen.height/2)-225);
            loseBest.position = new Vector2 ((Screen.width/2), (Screen.height/2)+300);
            loseBest.localScale =new Vector2(2*transform.localScale.x, 2*transform.localScale.y);
            newLoseBest.position = new Vector2 ((Screen.width/2), (Screen.height/2)+300);
            newLoseBest.localScale =new Vector2(2*transform.localScale.x, 2*transform.localScale.y);
            pausedBest.position = new Vector2 ((Screen.width/2), (Screen.height/2)+300);
            pausedBest.localScale =new Vector2(2*transform.localScale.x, 2*transform.localScale.y);
            yesButton.localScale =new Vector2(3*transform.localScale.x/2, 3*transform.localScale.y/2);
            noButton.localScale =new Vector2(3*transform.localScale.x/2, 3*transform.localScale.y/2);
            noButton.position = new Vector2 ((Screen.width/2), (Screen.height/2)-225);
            Corona1.localScale=new Vector3(9*transform.localScale.x/10, 9*transform.localScale.y/10, 1);
            Corona2.localScale=new Vector3(9*transform.localScale.x/10, 9*transform.localScale.y/10, 1);
            Corona3.localScale=new Vector3(9*transform.localScale.x/10, 9*transform.localScale.y/10, 1);
            Corona4.localScale=new Vector3(9*transform.localScale.x/10, 9*transform.localScale.y/10, 1);
            Corona5.localScale=new Vector3(9*transform.localScale.x/10, 9*transform.localScale.y/10, 1);
             FindObjectOfType<vertPlayer>().mapWidth = 2.0f;
     }else if(Screen.width == 828 && Screen.height == 1792){ // Iphone XR
            scorePosition.position = new Vector2 ((Screen.width-Screen.width)+125, (Screen.height)-125);
            scoreLose.position = new Vector2 ((Screen.width-Screen.width)+125, (Screen.height)-125);
            pausePosition.position = new Vector2 ((Screen.width)-125, (Screen.height)-115);
            resumeButton.position = new Vector2 ((Screen.width)-125, (Screen.height)-115);
            AdsButton.position = new Vector2 ((Screen.width)-125, (Screen.height)-115);
            fight00.position = new Vector2((Screen.width/2), (Screen.height)-415);
            fight01.position = new Vector2((Screen.width/2), (Screen.height)-415);
            fightPaused.position = new Vector2((Screen.width/2), (Screen.height)-415);
            CovidFreeTitle.position = new Vector2((Screen.width/2), (Screen.height)-415);
            Infected.position = new Vector2((Screen.width/2), (Screen.height)-415);
            tapToStart.position = new Vector2((Screen.width/2), (Screen.height/2)-515);
            loseBest.position = new Vector2 ((Screen.width/2), (Screen.height/2)+200);
            loseBest.localScale =new Vector2(3*transform.localScale.x/2, 3*transform.localScale.y/2);
            newLoseBest.position = new Vector2 ((Screen.width/2), (Screen.height/2)+200);
            newLoseBest.localScale =new Vector2(3*transform.localScale.x/2, 3*transform.localScale.y/2);
            pausedBest.position = new Vector2 ((Screen.width/2), (Screen.height/2)+200);
            pausedBest.localScale =new Vector2(3*transform.localScale.x/2, 3*transform.localScale.y/2);
            Corona1.localScale=new Vector3(9*transform.localScale.x/10, 9*transform.localScale.y/10, 1);
            Corona2.localScale=new Vector3(9*transform.localScale.x/10, 9*transform.localScale.y/10, 1);
            Corona3.localScale=new Vector3(9*transform.localScale.x/10, 9*transform.localScale.y/10, 1);
            Corona4.localScale=new Vector3(9*transform.localScale.x/10, 9*transform.localScale.y/10, 1);
            Corona5.localScale=new Vector3(9*transform.localScale.x/10, 9*transform.localScale.y/10, 1);
             FindObjectOfType<vertPlayer>().mapWidth = 2.0f;
}else if(Screen.width == 750 && Screen.height == 1334){ 
          Corona1.localScale=new Vector3(1, 1, 1);
            Corona2.localScale=new Vector3(1, 1, 1);
            Corona3.localScale=new Vector3(1, 1, 1);
            Corona4.localScale=new Vector3(1, 1, 1);
            Corona5.localScale=new Vector3(1, 1, 1);
     }
}
}