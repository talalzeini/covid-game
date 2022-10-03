using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerScript : MonoBehaviour
{
    public AudioSource jump;

    public Text MaskCount;

    public AudioSource plusOne;
    public GameObject losePanel;
    public GameObject winPanel;
    public GameObject gameTitle;
    public Rigidbody2D rb;
    private SpriteRenderer sr;
    public Transform Cam;
    private gameManager spawnerScript;
    public GameObject tapToStartText;
    public GameObject fight0;
    public GameObject fight1;

    public GameObject MaskObjects;

    public GameObject OneMask;

    public GameObject MoreMasks;
    public Sprite mask;
    public Sprite notMask;
    public GameObject explosion;
    public float velocity = 1;
    private Spawner spawner;

    public playerScript myPlayerScript;
    void Start(){
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        fight0.SetActive(false);
        fight1.SetActive(true);
        losePanel.SetActive(false);
        winPanel.SetActive(false);
        gameTitle.SetActive(true);
        MaskObjects.SetActive(false);
        OneMask.SetActive(false);
        MoreMasks.SetActive(false);    
}
   
     public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || (Input.GetMouseButtonDown(0))){
            rb.velocity = Vector2.up * velocity;
            rb.isKinematic = false;
            tapToStartText.SetActive(false);
            fight0.SetActive(true);
            fight1.SetActive(false);
            jump.Play();
        }
        if(int.Parse(MaskCount.text) == 0){
      MaskObjects.SetActive(false);
        }
        if(int.Parse(MaskCount.text) == 1){
      MaskObjects.SetActive(true);
      OneMask.SetActive(true);
      MoreMasks.SetActive(false);
        }
        if(int.Parse(MaskCount.text) > 1){
      OneMask.SetActive(false);
      MoreMasks.SetActive(true);
      MaskObjects.SetActive(true);
        }
        
    }
void OnCollisionEnter2D(Collision2D col){
        
        if(sr.sprite == mask && col.gameObject.CompareTag("Corona")){
        Destroy(col.gameObject);
        MaskCount.text = (int.Parse(MaskCount.text)-1).ToString();
        if(int.Parse(MaskCount.text) == 0){
        sr.sprite = notMask;
        }
     

}else if(sr.sprite != mask){
      //  rb.constraints = RigidbodyConstraints2D.None;
            if (col.gameObject.CompareTag("Corona")){
                losePanel.SetActive(true);
                winPanel.SetActive(false);
                gameTitle.SetActive(false);
                Destroy(col.gameObject);
                myPlayerScript.enabled = false;
        }
    }
}
public void OnTriggerEnter2D(Collider2D coll){
   if(coll.gameObject.CompareTag("Mask")){
                     
            sr.sprite = mask;
            Destroy(coll.gameObject);
    }
   if(coll.gameObject.CompareTag("Mask") && sr.sprite == mask){
       MaskCount.text = (int.Parse(MaskCount.text)+1).ToString();
   }
      if (coll.gameObject.CompareTag("End")){
        losePanel.SetActive(false);
        gameTitle.SetActive(false);
        winPanel.SetActive(true);
        rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
     if(coll.gameObject.CompareTag("Spawn")){
                     
           FindObjectOfType<Spawner>().Spawning();
           Destroy(coll.gameObject);
           plusOne.Play();
    }
}
}
