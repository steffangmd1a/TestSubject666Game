using UnityEngine;
using System.Collections;

public class ActivateArm : MonoBehaviour {

    public bool arm;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(arm == true)
        {

            GetComponent<SkinnedMeshRenderer>().enabled = true;

        }
	
	}

    public void Activate(bool active)
    {

        arm = active;

    }
}
