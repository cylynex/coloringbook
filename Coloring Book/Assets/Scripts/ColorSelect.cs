using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSelect : MonoBehaviour {

    public Color thisColor;
    public GameObject gameController;

    void Start() {
        Debug.Log("Color Picker is alive");
        gameController = GameObject.FindGameObjectWithTag("GameController");
    }

    void OnMouseDown() {
        Debug.Log("Clicked a thing");
    }

    // Set the actual color
    public void ChooseColor() {
        Debug.Log("Setting Color now...");
        //gameController.GetComponent<GameController>().currentColor = thisColor;
        gameController.GetComponent<GameController>().SetActiveColor(thisColor);
    }

}

