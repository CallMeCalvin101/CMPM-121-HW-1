using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// From 10/21/2022 Lecture
public class DayNightScript : MonoBehaviour
{
    [Range(0.0f, 1.0f)]
    public float time;
    public float fullDayLength;
    public float startTime = 0.4f;
    public float brightness = 1f;
    private float timeRate;
    public Vector3 noon;

    [Header("Sun")]
    public Light sun;
    public Gradient sunColor;
    public AnimationCurve sunIntensity;

    [Header("Moon")]
    public Light moon;
    public Gradient moonColor;
    public AnimationCurve moonIntensity;

    [Header("Skybox")]
    public Skybox skybox;
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

        sun.transform.eulerAngles=(time - 0.25f)*noon*4.0f;
        moon.transform.eulerAngles=(time - 0.75f)*noon*4.0f;

        sun.intensity = brightness * sunIntensity.Evaluate(time);
        moon.intensity = brightness * moonIntensity.Evaluate(time);

        RenderSettings.skybox.SetColor("_Tint", skyColor.Evaluate(time));
    }
}
