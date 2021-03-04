using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PantallaVida : MonoBehaviour {
    public Text texto;
    public Vida vida;

	 // Use this for initialization
  	void Start () {
		
	}
	
	 // Update is called once per frame
	  void Update () {
        texto.text = vida.valor + "/100";
	}
}

