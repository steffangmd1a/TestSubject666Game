using UnityEngine;
using System.Collections;

public class SaveGame : MonoBehaviour {

    public int level;

	// Use this for initialization
	void Start () {

        level = 1;

        INIParser ini = new INIParser();
        ini.Open(Application.dataPath + "TS.ini");
        ini.WriteValue("Stats", "level", "1");
        ini.Close();


    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
