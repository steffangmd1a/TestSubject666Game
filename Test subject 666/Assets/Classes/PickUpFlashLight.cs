using UnityEngine;
using System.Collections;
using System;

public class PickUpFlashLight : MonoBehaviour {

    public bool coll;
    public bool actives;
    public int plus;
    public GameObject Target;
    public GameObject FlashLight;
    public GameObject arm;
    public bool active = true;

	// Use this for initialization
	void Start () {

        coll = false;
        actives = false;
	
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetButtonDown("Open") && coll == true && actives == false)
        {

            Destroy(gameObject);
            actives = true;
            FlashLightController ac = (FlashLightController)Target.GetComponent("FlashLightController");
            ac.AddjustActive(true);
            ac.GotIt(true);
            ac.PlusOne(1);
            GotFlash gf = (GotFlash)FlashLight.GetComponent("GotFlash");
            gf.Change(true);
            ActivateArm am =(ActivateArm)arm.GetComponent("ActivateArm");
            am.Activate(true);
            

        }

	}

    void OnTriggerEnter (Collider Player)
    {

        coll = true;

    }

    void OnTriggerExit(Collider Player)
    {

        coll = false;

    }

    void OnGUI()
    {

        if(coll == true)
        {

            GUI.Box(new Rect(10, 10, Screen.width / 3, 25), "Press E to take the Flashlight");

        }

    }
}
