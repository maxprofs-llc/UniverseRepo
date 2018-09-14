using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inhabitant : MonoBehaviour {
    public string Species;
    public int population;
	// Use this for initialization
	public void init () {
        population = Random.Range(15000, 9999999);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
