using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    public Restart Restart;

    public Rigidbody2D rb;
    public float jumpAmount;
    public int sc;
    public string last = "Down";
    public bool enabled = true;
    public void GameOver(){
        Restart.Setup(sc);
    }

    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Enemy"){ //if touching enemy
            AudioSource[] audio = FindObjectsOfType<AudioSource>();
            foreach (AudioSource a in audio)
                a.Pause();
            GameOver();
            Destroy(gameObject);
        }
        else
            if(enabled) sc++;
    }

    


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow) && enabled == true)
        {
            if(last == "Down"){ //if your character is moving down or is on the ground
                rb.velocity = new Vector2(0,0);
                rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse); //pressing button moves you up
                last = "Up"; //you are now moving up
            }
            else{
                rb.velocity = new Vector2(0,0);
                rb.AddForce(Vector2.up * -jumpAmount, ForceMode2D.Impulse); //else pressing the button moves you down
                last = "Down"; //you are now moving down

            }
            
        }
        
    }

    
}
