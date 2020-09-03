using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Try1CreateSpheres : MonoBehaviour
{
	private GameObject s;
	private Rigidbody rb;
	private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    	if (counter <= 75) 
    	{
    		counter++;
    		if (s.transform.position.y <= 0.5)
			Destroy(s);
    	} else {
    		counter = 0;
    		s = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		s.transform.position = new Vector3 (((Random.value*50) % 8) - ((Random.value*50) % 8), 5, ((Random.value*50) % 8) - ((Random.value*50) % 8));
		rb = s.gameObject.AddComponent(typeof(Rigidbody)) as Rigidbody;
	//yield return new WaitForSecondsRealtime(5);
    	}      
    }
}
