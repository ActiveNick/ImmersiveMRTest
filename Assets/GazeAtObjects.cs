using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeAtObjects : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeColor(Color color)
    {
        Renderer r = gameObject.GetComponent<Renderer>();

        r.material.color = color;
    }
}
