using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpawnUIDetails : MonoBehaviour {
    public Canvas UIref;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.GetComponent<DetailsScript>())
                {
                   Canvas CanvasObj = Instantiate(UIref);
                    CanvasObj.GetComponent<UIScript>().detailsImg.rectTransform.position = new Vector2(Input.mousePosition.x + (CanvasObj.GetComponent<UIScript>().detailsImg.rectTransform.rect.width/2), Input.mousePosition.y - (CanvasObj.GetComponent<UIScript>().detailsImg.rectTransform.rect.height/2));
                    CanvasObj.GetComponent<UIScript>().detailsText.text = hit.collider.GetComponent<DetailsScript>().returnDetails();
                }
            }
        }
    }
}
