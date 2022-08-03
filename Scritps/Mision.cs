using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;


public class Mision : MonoBehaviour
{
    public TextMeshProUGUI txtEniy;
    public TextMeshProUGUI txtRefEniy;
    public TextMeshProUGUI txtEniyRef;
    public TextMeshProUGUI txtQTEniy;
    public TextMeshProUGUI typeMision;

    public TextMeshProUGUI txtPoweup;
    public int qtEnimy;
    // Start is called before the first frame update
    void Start()
    {
        typeMision.text = "Elimine";
        txtQTEniy.text = "50";
        txtEniyRef.text = txtQTEniy.text;
        txtEniy.text = "Enimigos";
        txtPoweup.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        txtRefEniy.text = qtEnimy.ToString();   
    }
}
