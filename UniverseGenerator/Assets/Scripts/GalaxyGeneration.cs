using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalaxyGeneration : MonoBehaviour {
    public GameObject planetRef;

    int planetSize;
    float planetSpawn = 0;
    GameObject[] planets;
	// Use this for initialization
	void Start () {
        int planetSize = Random.Range(6, 15);
        planetSpawn += this.transform.localScale.x;
        planets = new GameObject[planetSize];
		for (int i = 0; i < planetSize; i++ )
        {
            GameObject planet = Instantiate(planetRef);
            planet.GetComponent<PlanetScript>().init();
            planetSpawn += planet.GetComponent<PlanetScript>().size;
            planet.transform.position = new Vector3(planetSpawn, 0, 0);
            planetSpawn += planet.GetComponent<PlanetScript>().size;
            planet.transform.parent = this.transform;
            this.transform.eulerAngles = new Vector3(0, Random.Range(0, 360), 0);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
