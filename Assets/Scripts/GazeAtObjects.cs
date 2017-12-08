using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeAtObjects : MonoBehaviour {

    public Color focusColor;
    private Color previousColor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeColor()
    {

        Renderer r = gameObject.GetComponent<Renderer>();

        previousColor = r.material.color;
        r.material.color = focusColor;
    }

    public void ResetColor()
    {
        Renderer r = gameObject.GetComponent<Renderer>();

        r.material.color = previousColor;
    }
}
