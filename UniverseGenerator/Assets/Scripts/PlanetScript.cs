using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetScript : MonoBehaviour {
    public float size = 0;
    public Material[] planetSkin;


	// Use this for initialization
	public void init () {
        size = Random.Range(3, 7);
        int skin = Random.Range(0, planetSkin.Length);
        this.transform.localScale = new Vector3(size, size, size);
        this.GetComponent<Renderer>().material = planetSkin[skin];

    }
	
	// Update is called once per frame
	void Update () {
        transform.eulerAngles += new Vector3(0, 5 * Time.deltaTime, 0);
        transform.RotateAround(transform.parent.transform.position,new Vector3(0,1,0), (100 *Time.deltaTime) / (Vector3.Distance(this.transform.position, transform.parent.transform.position)));
	}
    // test github

    
}
