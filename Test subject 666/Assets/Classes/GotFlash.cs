using UnityEngine;
using System.Collections;

public class GotFlash : MonoBehaviour {

    public bool change = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(change == true)
        {

            GetComponent<MeshRenderer>().enabled = true;

        }
	
	}

    public void Change(bool actives)
    {

        change = actives;

    }
}
