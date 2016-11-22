using UnityEngine;
using System.Collections;

public class LevelCheck : MonoBehaviour {

    public int levelData;

	// Use this for initialization
	void Start () {
	
	}

    public void Check(int levelCounter)
    {

        levelData = levelCounter;

    }
}
