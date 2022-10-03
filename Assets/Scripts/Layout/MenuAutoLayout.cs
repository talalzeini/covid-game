using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuAutoLayout : MonoBehaviour
{
    public Transform fightTitle;

    public Transform themesTitle;

    public Transform optionsTitle;
    public Text themesText;
    public Text optionsText;

    public Transform bestScoreMain;

    public Transform tapText;
    void Update()
    {
           if((Screen.width == 1125 && Screen.height == 2436) || (Screen.width == 1242 && Screen.height == 2688)){ // Iphone XS   XS MAX  // Iphone XS
            fightTitle.position = new Vector2((Screen.width/2), (Screen.height)-550);
            fightTitle.localScale = new Vector2(3*transform.localScale.x/2, 3*transform.localScale.y/2);
            themesTitle.position = new Vector2((Screen.width/2), (Screen.height/2)-650);
            optionsTitle.position = new Vector2((Screen.width/2), (Screen.height/2)-850);
            themesText.fontSize = 120;
            optionsText.fontSize = 120;
            bestScoreMain.localScale =new Vector2(15*transform.localScale.x/10, 15*transform.localScale.y/10);
 }else if((Screen.width == 828 && Screen.height == 1792) || (Screen.width == 1080 && Screen.height == 1920)){ 
            fightTitle.position = new Vector2((Screen.width/2), (Screen.height)-415);
            themesTitle.position = new Vector2((Screen.width/2), (Screen.height/2)-500);
            optionsTitle.position = new Vector2((Screen.width/2), (Screen.height/2)-625);
            bestScoreMain.localScale =new Vector2(12*transform.localScale.x/10, 12*transform.localScale.y/10);
         }
    }
}
