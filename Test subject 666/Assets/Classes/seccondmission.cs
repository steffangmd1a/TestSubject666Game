using UnityEngine;
using System.Collections;

public class seccondmission : MonoBehaviour {

    public float timeLeft = 10;
    public float speed = 4;
    public bool coll = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (coll == true)
        {
            timeLeft -= Time.deltaTime * speed;

            if (timeLeft < 0)
            {

                Destroy(gameObject);

            }
        }
    }

    void OnGUI()
    {

        if (coll == true)
        {

            GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 100, 25), "Find the key.");

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
}

