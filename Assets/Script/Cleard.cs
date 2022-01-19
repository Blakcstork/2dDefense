using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleard : MonoBehaviour
{

    public bool IsClearedEasy;
    public bool IsClearedNormal;
    public bool IsClearedHard;
    public GameObject EasyCleared, NormalCleared, HardCleared;
    // Start is called before the first frame update

    void Start()
    {
        if (IsClearedEasy)
            EasyCleared.SetActive(true);
        if (IsClearedHard)
            HardCleared.SetActive(true);
        if (IsClearedNormal)
            NormalCleared.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
