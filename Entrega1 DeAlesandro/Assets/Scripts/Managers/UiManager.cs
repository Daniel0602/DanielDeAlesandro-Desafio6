using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField] Slider HealthBarr;

    void Update()
    {
        HealthBarr.maxValue = PlayerStats.maxLife;
        HealthBarr.value = PlayerStats.life;
    }
}
