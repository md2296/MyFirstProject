using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Try1Cube : MonoBehaviour
{
	
	Rigidbody rb;
	float xInput;
	float zInput;
	int points;
	public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    	if (Input.GetKeyDown(KeyCode.Space))
    	{
        	rb.AddForce(Vector3.up * 200);
        }
        
        if (gameObject.transform.position.y <= -1)
			Destroy(gameObject);
        
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
        
        rb.AddForce(xInput * speed, 0, zInput * speed);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
    	if(collision.gameObject.tag != "MyPlane")
    	{
    		points++;
    		Destroy(collision.gameObject);
    	}
    }
}
