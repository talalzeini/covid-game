using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BestMenu : MonoBehaviour
{
    public GameObject BestTextMenu;

    public GameObject BestScoreMenu;
    void Start()
    {
        BestTextMenuAppearing();
    }
    void BestTextMenuAppearing(){
        BestTextMenu.SetActive(true);
        BestScoreMenu.SetActive(false);
        Invoke("BestScoreMenuAppearing", 3);
    }
    void BestScoreMenuAppearing(){
        BestTextMenu.SetActive(false);
        BestScoreMenu.SetActive(true);
        Invoke("BestTextMenuAppearing", 3);
    }
}
