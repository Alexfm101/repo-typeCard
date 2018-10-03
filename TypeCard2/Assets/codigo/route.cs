using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class route : MonoBehaviour {
	// Use this for initialization
       public float rotationSpeed;
 
     void Update ()
     {
         transform.Rotate (0, rotationSpeed * Time.deltaTime, 0);
     }
}
