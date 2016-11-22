using UnityEngine;
using System.Collections;

public class GetKey : MonoBehaviour
{

    public bool coll;
    public bool gotkey;
    public GameObject Target;
    public GameObject TargetTwo;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetButtonDown("Open") && coll)
        {

            ScareJump ac = (ScareJump)Target.GetComponent("ScareJump");
            ac.Gettingkey(true);

            OpenDoorLock od = (OpenDoorLock)TargetTwo.GetComponent("OpenDoorLock");
            od.addjustkey(true);

            gotkey = true;

            Destroy(gameObject);

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

    void OnGUI()
    {
        if (coll == true)
        {
            GUI.Box(new Rect(10, 10, Screen.width / 3, 25), "Press E to take the key");
        }
    }
}
