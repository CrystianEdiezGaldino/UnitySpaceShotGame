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
    public TextMeshProUGUI txtLevel;
    public TextMeshProUGUI txtPoweup;
    public int qtEnimy;
    public int getPowe = 1;
    // Start is called before the first frame update
    void Start()
    {
        typeMision.text = "Elimine";
        txtQTEniy.text = "1500";
        txtEniyRef.text = txtQTEniy.text;
        txtEniy.text = "Enimigos";
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (qtEnimy>= 1500)
        {
            typeMision.text = "Misão Concluida";
            txtQTEniy.text = "";
            txtEniy.text = "";

        }
        switch (getPowe)
        {
            case 1:
                txtLevel.text = "Level 01";
                break;
            case 2:
                txtLevel.text = "Level 02";
                break;
            case 3:
                txtLevel.text = "Level 03";
                break;

            default:
                print("Boss");
                break;
        }
        txtPoweup.text = getPowe.ToString();
        txtRefEniy.text = qtEnimy.ToString();   
    }
}
