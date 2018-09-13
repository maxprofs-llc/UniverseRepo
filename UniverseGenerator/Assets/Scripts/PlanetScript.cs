﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetScript : MonoBehaviour {
    public string Name;
    public float size = 0;
    public Material[] planetSkin;


	// Use this for initialization
	public void init () {
        Name = ReturnRandomName();
        size = Random.Range(3, 7);
        int skin = Random.Range(0, planetSkin.Length);
        this.transform.localScale = new Vector3(size, size, size);
        this.GetComponent<Renderer>().material = planetSkin[skin];

    }
	
	// Update is called once per frame
	void Update () {

	}
    // test github

    string ReturnRandomName()
    {
        int Rnd = Random.Range(0, 30);
        string NameRtn;
        switch (Rnd)
        {
            case 0:
                NameRtn = "Penrith";
                break;
            case 1:
                NameRtn = "Zorga";
                break;
            case 2:
                NameRtn = "Crymio";
                break;
            case 3:
                NameRtn = "Dmitrus";
                break;
            case 4:
                NameRtn = "Kroza";
                break;
            case 5:
                NameRtn = "Morra";
                break;
            case 6:
                NameRtn = "Angla";
                break;
            case 7:
                NameRtn = "Destra";
                break;
            case 8:
                NameRtn = "Cloudsia";
                break;
            case 9:
                NameRtn = "Regol";
                break;
            case 10:
                NameRtn = "Gimastri";
                break;
            case 11:
                NameRtn = "Proza";
                break;
            case 12:
                NameRtn = "Brovo";
                break;
            case 13:
                NameRtn = "Canto";
                break;
            case 14:
                NameRtn = "Plinkza";
                break;
            case 15:
                NameRtn = "Jermi";
                break;
            case 16:
                NameRtn = "Gemini";
                break;
            case 17:
                NameRtn = "Yestra";
                break;
            case 18:
                NameRtn = "Questx";
                break;
            case 19:
                NameRtn = "Faliz";
                break;
            case 20:
                NameRtn = "Westyu";
                break;
            case 21:
                NameRtn = "Imonga";
                break;
            case 22:
                NameRtn = "Bumbal";
                break;
            case 23:
                NameRtn = "Synt";
                break;
            case 24:
                NameRtn = "Hielos";
                break;
            case 25:
                NameRtn = "MK-42";
                break;
            case 26:
                NameRtn = "Sampu";
                break;
            case 27:
                NameRtn = "Cliva";
                break;
            case 28:
                NameRtn = "Ohno";
                break;
            case 29:
                NameRtn = "Mazin";
                break;
            default:
                NameRtn = "No Name";
                break;
        }

        return NameRtn;
    }
}
