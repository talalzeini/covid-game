using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemesAutoLayout : MonoBehaviour
{
    public Transform themesTitle;

    public Transform fightText;
    public Transform fallText;
    public Transform backButton;
    void Update()
    {
        if(Screen.width == 1125 && Screen.height == 2436){  // Iphone XS
            themesTitle.position = new Vector2((Screen.width/2), (Screen.height)-550);
            themesTitle.localScale = new Vector2(3*transform.localScale.x/2, 3*transform.localScale.y/2);
            fightText.localScale =new Vector2(15*transform.localScale.x/10, 15*transform.localScale.y/10);
            fallText.localScale =new Vector2(15*transform.localScale.x/10, 15*transform.localScale.y/10);
            backButton.position = new Vector2 ((Screen.width-Screen.width)+150, (Screen.height)-150);
            backButton.localScale = new Vector2(3*transform.localScale.x/2, 3*transform.localScale.y/2);
         }else if(Screen.width == 828 && Screen.height == 1792){  // Iphone XR
            backButton.position = new Vector2 ((Screen.width-Screen.width)+125, (Screen.height)-125);
            themesTitle.position = new Vector2((Screen.width/2), (Screen.height)-415);
        }
}
}
