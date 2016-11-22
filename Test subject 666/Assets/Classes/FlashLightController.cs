using UnityEngine;
using System.Collections;

public class FlashLightController : MonoBehaviour {

    public float power;
    public float maxPower;
    public int bat;
    public float powerCost;
    public bool powerOn = false;
    public int powerOnInt =0;
    public bool powerAble = false;
    public int powerAbleInt = 0;
    public bool gotFlash = false;
    public int gotFlashInt = 0;
    public bool active = false;
    public int activeInt = 0;

    // Use this for initialization
    void Awake() {

        GetComponent<Light>().enabled = false;
        power = 100;
        maxPower = 100;
        bat = 2;
        powerCost = 0.5f;
        if (powerOnInt == 1)
        {

            powerOn = true;

        }

        if(powerAbleInt == 1)
        {

            powerAble = true;

        }

        if(gotFlashInt == 1)
        {

            gotFlash = true;

        }

        if(activeInt == 1)
        {

            active = true;

        }
    }
	
	// Update is called once per frame
	void Update () {

        if(Input.GetButtonDown("Fire2"))
        {

            if(powerOn == false && powerAble == true && gotFlash == true)
            {

                powerOn = true;
                GetComponent<Light>().enabled = true;

            } else if(powerOn == true && gotFlash == true)
            {

                powerOn = false;
                GetComponent<Light>().enabled = false;

            }

        }

        if (powerOn == true)
        {

            power -= Time.deltaTime * powerCost;

        }

        if(power < 0)
        {

            powerOn = false;
            power = 0;
            GetComponent<Light>().enabled = false;

        }

        if(Input.GetButtonDown("Reload"))
        {

            if(gotFlash == true)
            {

                if(bat > 0)
                {

                    if(power < 30)
                    {

                        bat -= 1;
                        power = 100;

                    }

                }

            }

        }

    }

    public void AddjustActive(bool actives)
    {

        active = actives;

    }

    public void GotIt(bool actives)
    {

        gotFlash = actives;

    }

    public void PlusOne (int plus)
    {

        gotFlashInt = plus;
        activeInt = plus;

    }

    void OnGUI ()
    {

        if(gotFlash == true)
        {

            GUI.Box(new Rect(10, Screen.height - 20, Screen.width / 2 / (maxPower / power), 25), "power" );
            GUI.Box(new Rect(10, Screen.height - 50, 150, 25), bat + " Batteries");

        }

    }
}
