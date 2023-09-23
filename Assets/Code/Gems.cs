using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gems : MonoBehaviour
{
    public int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.right * Time.deltaTime * -speed); //move objects across screen
    }

    void OnTriggerEnter2D(Collider2D col){
            Score.instance.AddPoint();
            Destroy(this.gameObject);
    }
}
