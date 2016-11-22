using UnityEngine;
using System.Collections;
using System;

public class ScareJump : MonoBehaviour {

    public bool coll;
    public bool getkey;
    public bool active;
    public bool flash;
    public bool flashy;
    public GameObject light;
    public GameObject scaryface;
    public float timer = 10;
    public AudioClip screamsound;
    AudioSource audio;

	// Use this for initialization
	void Awake () {

        audio = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {

        if(coll == true && getkey == true)
        {

            light.GetComponent<Light>().enabled = true;
            scaryface.GetComponent<MeshRenderer>().enabled = true;
            
            if(flashy == false)
            {

                flash = true;
                flashy = true;

            }


            active = true;

        }

        if(flash == true)
        {

            flash = false;

            audio.PlayOneShot(screamsound);

        }

        if(active == true)
        {

            timer -= Time.deltaTime;

        }

        if(timer < 0)
        {

            Destroy(light);
            Destroy(scaryface);

        }
	
	}

    public void Gettingkey(bool gotkey)
    {

        getkey = gotkey;

    }

    void OnTriggerEnter(Collider Player)
    {

        coll = true;

    }

    void OnTriggerExit(Collider Player)
    {

        coll = false;

    }
}
