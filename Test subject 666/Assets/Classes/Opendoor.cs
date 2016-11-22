using UnityEngine;
using System.Collections;

public class Opendoor : MonoBehaviour {

    public bool open = false;
    public bool coll = false;
    public float doorOpenAngle = -90f;
    public float doorCloseAngle = 0f;
    public float smooth = 2f;

    public AudioClip doorSound;
    AudioSource audio;

	// Use this for initialization
	void Awake () {

        audio = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {

        OpenAndClose();

        if(Input.GetButtonDown("Open") && coll == true)
        {

            if(open == false)
            {

                open = true;

            } else if (open == true)
            {

                open = false;

            }

        }

        if (Input.GetButtonDown("Open") && coll == true)
        {

            audio.PlayOneShot(doorSound);

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

            GUI.Box(new Rect(10, 10, Screen.width / 3, 25), "Press E to Open the door");

        }

    }

    public void OpenAndClose()
    {

        if(open == true)
        {

            Quaternion targetRotation1 = Quaternion.Euler(0, doorOpenAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation1, smooth * Time.deltaTime);

        } else if (open == false)
        {

            Quaternion targetRotation2 = Quaternion.Euler(0, doorCloseAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, smooth * Time.deltaTime);

        }

    }
}
