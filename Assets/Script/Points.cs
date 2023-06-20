using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public float points;
    public Text txtPoints;
    // Start is called before the first frame update
    void Start()
    {
        points = PlayerPrefs.GetFloat("Puntos");
        txtPoints.text = "" + PlayerPrefs.GetFloat("Puntos");
        
       

    }

    // Update is called once per frame
    void Update()
    {
        txtPoints.text = "" + PlayerPrefs.GetFloat("Puntos");
    }

    public void SumarPuntos(float punto)
    {
        points += punto;
        PlayerPrefs.SetFloat("Puntos", points);
        if (PlayerPrefs.GetFloat("Puntos") <= 0)
        {
            PlayerPrefs.SetFloat("Puntos", 0);
            txtPoints.text = "" + PlayerPrefs.GetFloat("Puntos");


        }
    }

    public void RestarPuntos(float punto)
    {
        points -= punto;
        PlayerPrefs.SetFloat("Puntos", points);
        if (PlayerPrefs.GetFloat("Puntos") <= 0)
        {
            PlayerPrefs.SetFloat("Puntos", 0);
            txtPoints.text = "" + PlayerPrefs.GetFloat("Puntos");


        }
    }
}
