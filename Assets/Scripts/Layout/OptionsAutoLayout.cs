using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsAutoLayout : MonoBehaviour
{
    public Transform themesTitle;

    public Transform muteAllSounds;
    public Transform ResetButton;

    public Transform muteMusic;
    public Transform backButton;
    void Update()
    {
  if((Screen.width == 1125 && Screen.height == 2436) || (Screen.width == 1242 && Screen.height == 2688)){ // Iphone XS   XS MAX  // Iphone XS// Iphone XS
            themesTitle.position = new Vector2((Screen.width/2), (Screen.height)-550);
            themesTitle.localScale = new Vector2(3*transform.localScale.x/2, 3*transform.localScale.y/2);
            ResetButton.localScale =new Vector2(15*transform.localScale.x/10, 15*transform.localScale.y/10);
            muteMusic.localScale =new Vector2(15*transform.localScale.x/10, 15*transform.localScale.y/10);
            muteAllSounds.localScale =new Vector2(15*transform.localScale.x/10, 15*transform.localScale.y/10);
            backButton.position = new Vector2 ((Screen.width-Screen.width)+150, (Screen.height)-150);
            backButton.localScale = new Vector2(3*transform.localScale.x/2, 3*transform.localScale.y/2);
     }else if((Screen.width == 828 && Screen.height == 1792) || (Screen.width == 1080 && Screen.height == 1920)){
            backButton.position = new Vector2 ((Screen.width-Screen.width)+125, (Screen.height)-125);
            themesTitle.position = new Vector2((Screen.width/2), (Screen.height)-415);
        }
}
}
