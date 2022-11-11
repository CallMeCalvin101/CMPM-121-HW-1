using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxtint : MonoBehaviour
{
    [Range(0.0f, 1.0f)]
    public float time;
    public float fullDayLength;
    public float startTime = 0.4f;
    private float timeRate;

    public Gradient skyColor;

    // Start is called before the first frame update
    void Start()
    {
        timeRate = 1.0f/fullDayLength;
        time = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        time += timeRate*Time.deltaTime;
        time %= 1.0f;
        RenderSettings.skybox.SetColor("_SkyTint", Color.red);
    }
}
