using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Try_to_locks : MonoBehaviour
{
    public GameObject gameObject;
	void Start () {
		
	}
	void Update () {
	    if (Input.GetMouseButton(0))
	    {
	        Debug.Log("Work");
	        transform.Rotate(Vector3.up, Time.deltaTime * 13);
            
	    }
	}
}
