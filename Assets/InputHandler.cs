using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class InputHandler : MonoBehaviour
{

    public float ot;
    public float tiz;
    public float husz;
    public float otven;
    public float szaz;
    public float ketszaz;

    public TextMeshProUGUI otT;
    public TextMeshProUGUI tizT;
    public TextMeshProUGUI huszT;
    public TextMeshProUGUI otvenT;
    public TextMeshProUGUI szazT;
    public TextMeshProUGUI ketszazT;

    float palacsinta;
    public TextMeshProUGUI palacsintaT;

    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void Update()
    {
        otT.text = ot.ToString();
        tizT.text = tiz.ToString();
        huszT.text = husz.ToString();
        otvenT.text = otven.ToString();
        szazT.text = szaz.ToString();
        ketszazT.text = ketszaz.ToString();

        palacsinta = ((ot*5 + tiz*10 + husz*20 + otven*50 + szaz*100 + ketszaz*200) / 380);
        palacsintaT.text = palacsinta.ToString();
    }



    public void otV(bool pl)
    {
        if (pl)
        {
            ot++;
        }
        else
        {
            ot--;
        }
    }
    public void tizV(bool pl)
    {
        if (pl)
        {
            tiz++;
        }
        else
        {
            tiz--;
        }
    }
    public void huszV(bool pl)
    {
        if (pl)
        {
            husz++;
        }
        else
        {
            husz--;
        }
    }
    public void otvenV(bool pl)
    {
        if (pl)
        {
            otven++;
        }
        else
        {
            otven--;
        }
    }
    public void szazV(bool pl)
    {
        if (pl)
        {
            szaz++;
        }
        else
        {
            szaz--;
        }
    }
    public void ketszazV(bool pl)
    {
        if (pl)
        {
            ketszaz++;
        }
        else
        {
            ketszaz--;
        }
    }   
}
