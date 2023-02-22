using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{ 
    public Rigidbody rigidbody;
    public float force = 1000f;
    public float speed = 16f;
    public float speed2 = 8f;
    public float MinX;
    public float MaxX;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = transform.position;
        playerPos.x=Mathf.Clamp(playerPos.x,MinX,MaxX);
        transform.position = playerPos;
        /* if (playerPos.x < MinX)
         {
             playerPos.x= MinX;
             transform.position = playerPos;
         }

         if (playerPos.x > MaxX)
         {
             playerPos.x = MaxX;
             transform.position = playerPos;
         }*/

        if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow)) { transform.position = transform.position + new Vector3(-speed * Time.deltaTime, 0, 0); }
        
        if (Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow)) { transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0); }
        
    }
    public void FixedUpdate()
    {
        transform.position = transform.position + new Vector3( 0, 0, speed2*Time.deltaTime);
    }
    
}
