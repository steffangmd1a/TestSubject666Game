using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

    public bool dead = false;

    public bool coll;

    public float time;

    public float speed;

    public GameObject target;

    void Awake ()
    {

        coll = false;

    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(coll == true)
        {

            Timer();

            target.GetComponent<MeshRenderer>().enabled = true;

        }

        if(time < 0)
        {

            Application.LoadLevel("mainmenu");

        }
	
	}

    void OnTriggerEnter(Collider Player)
    {

        coll = true;

    }

    void OnTriggerExit(Collider Player)
    {

        coll = false;

    }

    public void Timer()
    {

        time -= speed * Time.deltaTime;

    }
}
