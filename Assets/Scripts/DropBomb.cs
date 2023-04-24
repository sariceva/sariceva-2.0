using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBomb : MonoBehaviour
{
    public GameObject BombPrefab;

    void Start()
    {
        if (BombPrefab == null)
        {
            Debug.LogWarning("No BombPrefab hooked up!");
        }
    }


    void Update()
    {
        // Check for keypress (remember button input from chapter 7)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlaceBomb();
            Debug.Log("Bomb has been placed!");
        }
    }

    void PlaceBomb()
    {
        // Spawn a BombPrefab object
        GameObject bombObject = Instantiate(BombPrefab, transform.position, Quaternion.identity);
        // Set the parent of the bombObject to be the same as the parent of this script's game object
        bombObject.transform.SetParent(transform.parent);
    }
}
