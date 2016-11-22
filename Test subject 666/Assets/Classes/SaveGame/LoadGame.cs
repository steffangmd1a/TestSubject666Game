using UnityEngine;
using System.Collections;

public class LoadGame : MonoBehaviour {

    public float timer = 10f;
    public float smooth = 4f;

    public int level;

	// Use this for initialization
	void Start () {

        INIParser ini = new INIParser();
        ini.Open(Application.dataPath + "TS.ini");
        level = ini.ReadValue("stats", "level", 0);
        ini.Close();

    }
	
	// Update is called once per frame
	void Update () {

        TimerUpdate();

        if(timer < 0)
        {

            if (level == 0)
            {

                Application.LoadLevel("mainmenu");

            }
            else if (level == 1)
            {

                Application.LoadLevel("level1");

            }

        }

    }

    public void TimerUpdate()
    {

        timer -= Time.deltaTime * smooth;

    }
}