using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    GameManager gameManager;    // reference to the GameManager script
    Ray ray;                    // a ray object that will be used to detect where the player clicks
    RaycastHit hit;             // a hit object that will store information about what the ray hits

    private bool missileHit = false;   // a flag to indicate whether this tile has been hit by a missile yet
    Color32[] hitColor = new Color32[2];  // an array to store the two colors that this tile can be

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();   // get a reference to the GameManager script
        hitColor[0] = gameObject.GetComponent<MeshRenderer>().material.color;      // set the default color for this tile (color when it has not been hit)
        hitColor[1] = gameObject.GetComponent<MeshRenderer>().material.color;      // set the second color for this tile (color when it has been hit)
    }

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);   // create a ray that goes from the camera through the mouse position
        if(Physics.Raycast(ray, out hit))   // check if the ray hits anything
        {
            if(Input.GetMouseButtonDown(0) && hit.collider.gameObject.name == gameObject.name)   // check if the left mouse button is clicked and the ray hits this tile
            {
                if(missileHit == false)   // check if this tile has not been hit before
                {
                    gameManager.TileClicked(hit.collider.gameObject);   // call the TileClicked method in the GameManager script, passing in this tile's game object
                }
            }
        }
    }

    // called when this tile collides with another game object
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Missile"))   // check if the other game object has the "Missile" tag
        {
            missileHit = true;   // set the missileHit flag to true
        }
        else if (collision.gameObject.CompareTag("EnemyMissile"))   // check if the other game object has the "EnemyMissile" tag
        {
            hitColor[0] = new Color32(38, 57, 76, 255);   // set the tile color to a darker shade of blue
            GetComponent<Renderer>().material.color = hitColor[0];   // apply the new color to the tile
        }
                
    }

    // sets the color for one of the two possible colors for this tile
    public void SetTileColor(int index, Color32 color)
    {
        hitColor[index] = color;
    }

    // switches the tile color to one of the two possible colors
    public void SwitchColors(int colorIndex)
    {
        GetComponent<Renderer>().material.color = hitColor[colorIndex];
    }
}
