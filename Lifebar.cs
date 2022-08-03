using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lifebar : MonoBehaviour
{
    public Image imgLifebar;
    public float lifemax= 100;
    public float lifecurrent;
    // Start is called before the first frame update
    void Start()
    {
        lifecurrent = lifemax;
    }

    // Update is called once per frame
    void Update()
    {
        imgLifebar.fillAmount = lifecurrent /lifemax;
        if (lifecurrent<=0)
        {
            lifecurrent = 0;
        }
        if (lifecurrent >= 100)
        {
            lifecurrent = 100;
        }
    }
}
