using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawing : MonoBehaviour
{

    GameObject gameController;
    Color currentColor;

    void Start() {
        gameController = GameObject.FindGameObjectWithTag("GameController");
        //currentColor = this.GetComponent<SpriteRenderer>().color;
        currentColor = new Color32(255, 255, 255, 100);
    }

    void OnMouseDown() {
        Debug.Log("Ping");

        // Get current color
        Color newColor = gameController.GetComponent<GameController>().currentColor;
        Debug.Log("Got color: " + newColor);
        currentColor = newColor;
        this.GetComponent<SpriteRenderer>().color = newColor;

        // Set color of this item to current color
    }

    void OnMouseOver() {
        this.GetComponent<SpriteRenderer>().color = gameController.GetComponent<GameController>().highlightColor;
    }

    void OnMouseExit() {
        this.GetComponent<SpriteRenderer>().color = currentColor;
    }
}
