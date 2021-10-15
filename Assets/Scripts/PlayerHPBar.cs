using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPBar : MonoBehaviour
{
    public Slider hpBar;

    public void Damage()
    {
        hpBar.value -= 0.1f;
    }

    public void Heal()
    {
        hpBar.value += 0.1f;
    }
    // Start is called before the first frame update
    void Start()
    {
        hpBar.value = 1;
    }
}
