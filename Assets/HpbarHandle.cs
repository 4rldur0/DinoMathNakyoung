using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpbarHandle : MonoBehaviour
{
    [SerializeField]
    private Slider hpbarDino;
    [SerializeField]
    private Slider hpbarAlien;

    private float maxHp = 100;
    private float curHpDino = 100;
    private float curHpAlien = 100;

    void Start()
    {
        hpbarDino.value = (float)curHpDino / (float)maxHp;
        hpbarAlien.value = (float)curHpAlien / (float)maxHp;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            curHpDino -= 10;
        }
        else if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            curHpAlien -= 10;
        }
        HandleHp();
    }

    void HandleHp()
    {
        hpbarDino.value = (float)curHpDino / (float)maxHp;
        hpbarAlien.value = (float)curHpAlien / (float)maxHp;
    }
}
