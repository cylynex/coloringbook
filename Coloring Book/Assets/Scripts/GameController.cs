using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject paletteItem;
    public Transform paletteHolder;
    public Color currentColor;
    public GameObject paletteCurrentItem;
    public Color highlightColor;

    void Start() {
        currentColor = new Color32(0, 200, 0, 100);
        highlightColor = new Color32(255, 0, 0, 100);

        // instantiate a color GO
        // TODO put this in a class and subclass for palette / items (This will be a loop)
        GameObject thisPaletteItem = (GameObject)Instantiate(paletteItem, paletteHolder.position, Quaternion.identity);
        thisPaletteItem.transform.SetParent(paletteHolder, true);
        thisPaletteItem.GetComponent<Image>().color = new Color32(255, 255, 0, 100);

        // Set the color variable so the picker knows what its color is
        thisPaletteItem.GetComponent<ColorSelect>().thisColor = new Color32(255, 255, 0, 100);
                
    }


    public void SetActiveColor(Color newColor) {
        Debug.Log("Setting Active Color");
        paletteCurrentItem.GetComponent<ColorSelect>().thisColor = newColor;
        currentColor = newColor;
        paletteCurrentItem.GetComponent<Image>().color = newColor;
    }

}




//GameObject thisTile = (GameObject)Instantiate(tilePrefab, gameGrid.position, Quaternion.identity);
//thisTile.transform.SetParent(gameGrid, true);
//thisTile.GetComponent<Text>().text = allLetters[Random.Range(0, maxLetter)].ToString();