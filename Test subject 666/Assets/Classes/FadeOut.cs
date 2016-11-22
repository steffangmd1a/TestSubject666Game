using UnityEngine;
using System.Collections;

public class FadeOut : MonoBehaviour {

    public Texture2D fadeOutTexture;
    public float fadespeed = 0.8f;

    private int drawDepth = -1000;
    private float alpha = 0.0f;
    private int fadeDir = 1;

    public float timer = 100;
    public float counter = 2;

    public AudioClip scream;
    AudioSource audio;

    public float timerSound = 100;
    public float counterSound = 2;

    public float timerSoundTwo = 100;
    public float counterSoundTwo = 2;

    public AudioClip speach;


    void Awake()
    {

        audio = GetComponent<AudioSource>();

    }

    void OnGUI()
    {

        alpha = Mathf.Clamp01(alpha);

        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drawDepth;
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture);

    }

    void Update()
    {

        if(timer < 0)
        {

            alpha += fadeDir * fadespeed * Time.deltaTime;

        }

        timer -= counter * Time.deltaTime;

        timerSound -= counterSound * Time.deltaTime;

        timerSoundTwo -= counterSound * Time.deltaTime;

        if (timer < -10)
        {

            Application.LoadLevel("level1");

        }

        if (timerSound < 11)
        {

            audio.PlayOneShot(scream);
            timerSound = 100;

        }

        if (timerSoundTwo < 80)
        {

            audio.PlayOneShot(speach);
            timerSoundTwo = 100000;

        }

    }

    void Start()
    {



    }
}
