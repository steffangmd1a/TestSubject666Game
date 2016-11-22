using UnityEngine;
using System.Collections;

public class Level1Setup : MonoBehaviour {

    public GameObject Target;
    public GameObject FlashLight;
    public bool actives = true;


	// Use this for initialization
	void awake () {
	
	}
	
	// Update is called once per frame
	void Update () {
        FlashLightController ac = (FlashLightController)Target.GetComponent("FlashLightController");
        ac.AddjustActive(true);
        ac.GotIt(true);
        ac.PlusOne(1);
        GotFlash gf = (GotFlash)FlashLight.GetComponent("GotFlash");
        gf.Change(true);

    }
}
