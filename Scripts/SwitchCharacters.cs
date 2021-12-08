using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SwitchCharacters : MonoBehaviour
{
	public GameObject vbBtnObj;
	public GameObject character1;
	public GameObject character2;
	public GameObject character3;
	public GameObject character4;
    public GameObject character5;
	public int i = 0;

    // Start is called before the first frame update
    void Start()
    {
    	vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
    	i = i + 1;
        //Debug.Log("Button pressed");
    }
 
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //Debug.Log("Button released");
    }

    // Update is called once per frame
    void Update()
    {
    	if (i==0){
    		character1.SetActive(true);
    		character2.SetActive(false);
    		character3.SetActive(false);
    		character4.SetActive(false);
            character5.SetActive(false);
    	}else if (i==1){
    		character1.SetActive(false);
    		character2.SetActive(true);
    		character3.SetActive(false);
    		character4.SetActive(false);
            character5.SetActive(false);
    	}else if (i==2){
    		character1.SetActive(false);
    		character2.SetActive(false);
    		character3.SetActive(true);
    		character4.SetActive(false);
            character5.SetActive(false);
    	}else if (i==3){
    		character1.SetActive(false);
    		character2.SetActive(false);
    		character3.SetActive(false);
    		character4.SetActive(true);
            character5.SetActive(false);
    	}else if (i==4){
            character1.SetActive(false);
            character2.SetActive(false);
            character3.SetActive(false);
            character4.SetActive(false);
            character5.SetActive(true);
        }else{
    		i = 0;
    	}
        
    }
}
