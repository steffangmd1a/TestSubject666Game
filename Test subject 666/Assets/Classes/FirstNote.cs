using UnityEngine;
using System.Collections;

public class FirstNote : MonoBehaviour {

    public bool coll = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider Player)
    {

        coll = true;

    }

    void OnTriggerExit(Collider Player)
    {

        coll = false;

    }

    void OnGUI()
    {

        if (coll == true)
        {

            GUI.Box(new Rect(10, 10, 400, 60), "When i woke up i didnt remember anything.\n the Last thing i could remember is a man talking about paying a\n debt. But i needed to pay it with my life instead of money");

        }

    }
}
