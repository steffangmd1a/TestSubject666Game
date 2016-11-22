using UnityEngine;
using System.Collections;

public class BlackWalkerAI : MonoBehaviour {

    public Transform target;
    public int moveSpeed;
    public int rotateSpeed;
    public int maxDistance;

    public Transform myTransform;

    void Awake()
    {

        myTransform = transform;

    }

	// Use this for initialization
	void Start () {

        GameObject go = GameObject.FindGameObjectWithTag("Player");

        target = go.transform;

        maxDistance = 2;
	
	}
	
	// Update is called once per frame
	void Update () {

        myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotateSpeed * Time.deltaTime);

        if (Vector3.Distance (target.position, myTransform.position) > maxDistance)
        {

            myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;

        }
	
	}
}
