using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIScript : MonoBehaviour {
    public Text detailsText;
    public Image detailsImg;
    // Use this for initialization
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) || (Input.GetKeyDown(KeyCode.Mouse1)))
        {
            Destroy(this.gameObject);
        }
    }
}
