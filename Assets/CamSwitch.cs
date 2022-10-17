using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    //Adapted from https://fanzhongzeng78.medium.com/switching-cameras-in-unity-174ef13ec6e#:~:text=We%20first%20start%20by%20deciding,the%20button%20on%20the%20keyboard.
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;

    void Update() {
        if (Input.GetButtonDown("Switch1")) {
            cam1.SetActive(true);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
        }

        if (Input.GetButtonDown("Switch2")) {
            cam1.SetActive(false);
            cam2.SetActive(true);
            cam3.SetActive(false);
            cam4.SetActive(false);
        }

        if (Input.GetButtonDown("Switch3")) {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(true);
            cam4.SetActive(false);
        }

        if (Input.GetButtonDown("Switch4")) {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(true);
        }
    }
}
