using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class recipeControl : MonoBehaviour
{
	public GameObject vbBtnObj;
	public GameObject imgage;
    // Start is called before the first frame update
    void Start()
    {
    	vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        imgage.SetActive(true);
        //Debug.Log("Button pressed");
    }
 
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        imgage.SetActive(false);
        //Debug.Log("Button released");
    }

}
