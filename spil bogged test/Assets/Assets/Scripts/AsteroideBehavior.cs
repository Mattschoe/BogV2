using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroideBehavior : MonoBehaviour
{
    
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
        speed = Random.Range(10,20);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0,-speed*Time.deltaTime,0);
        if (transform.position.y <= -10) {
            Destroy(gameObject);
        
        }
    }
}
