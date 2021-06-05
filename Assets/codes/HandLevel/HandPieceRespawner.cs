using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandPieceRespawner : MonoBehaviour
{
    public GameObject greenPiece, pinkPiece, purplePiece, redPiece, yellowPiece, bluePiece;
    public GameObject greenStatue, pinkStatue, purpleStatue, redStatue, yellowStatue, blueStatue;
    public Vector3 greenPos, pinkPos, purplePos, redPos, yellowPos, bluePos;
    public Vector3 greenSpawn, pinkSpawn, purpleSpawn, redSpawn, yellowSpawn, blueSpawn;

    // Start is called before the first frame update
    void Start()
    {
        greenSpawn = new Vector3(greenPiece.GetComponent<Transform>().position.x, greenPiece.GetComponent<Transform>().position.y, 0);
        pinkSpawn = new Vector3(pinkPiece.GetComponent<Transform>().position.x, pinkPiece.GetComponent<Transform>().position.y, 0);
        purpleSpawn = new Vector3(purplePiece.GetComponent<Transform>().position.x, purplePiece.GetComponent<Transform>().position.y, 0);
        redSpawn = new Vector3(redPiece.GetComponent<Transform>().position.x, redPiece.GetComponent<Transform>().position.y, 0);
        yellowSpawn = new Vector3(yellowPiece.GetComponent<Transform>().position.x, yellowPiece.GetComponent<Transform>().position.y, 0);
        blueSpawn = new Vector3(bluePiece.GetComponent<Transform>().position.x, bluePiece.GetComponent<Transform>().position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        greenPos = new Vector3(greenPiece.GetComponent<Transform>().position.x, greenPiece.GetComponent<Transform>().position.y, 0);
        pinkPos = new Vector3(pinkPiece.GetComponent<Transform>().position.x, pinkPiece.GetComponent<Transform>().position.y, 0);
        purplePos = new Vector3(purplePiece.GetComponent<Transform>().position.x, purplePiece.GetComponent<Transform>().position.y, 0);
        redPos = new Vector3(redPiece.GetComponent<Transform>().position.x, redPiece.GetComponent<Transform>().position.y, 0);
        yellowPos = new Vector3(yellowPiece.GetComponent<Transform>().position.x, yellowPiece.GetComponent<Transform>().position.y, 0);
        bluePos = new Vector3(bluePiece.GetComponent<Transform>().position.x, bluePiece.GetComponent<Transform>().position.y, 0);

        if (greenStatue.GetComponent<SpriteRenderer>().enabled == false)
        {
            if (greenPos.y < -15)
            {
                greenPiece.GetComponent<Transform>().position = new Vector3(greenSpawn.x, greenSpawn.y, greenSpawn.z);
            }
        }
        if (pinkStatue.GetComponent<SpriteRenderer>().enabled == false)
        {
            if (pinkPos.y < -15)
            {
                pinkPiece.GetComponent<Transform>().position = new Vector3(pinkSpawn.x, pinkSpawn.y, pinkSpawn.z);
            }
        }
        if (purpleStatue.GetComponent<SpriteRenderer>().enabled == false)
        {
            if (purplePos.y < -15)
            {
                purplePiece.GetComponent<Transform>().position = new Vector3(purpleSpawn.x, purpleSpawn.y, purpleSpawn.z);
            }
        }
        if (redStatue.GetComponent<SpriteRenderer>().enabled == false)
        {
            if (redPos.y < -15)
            {
                redPiece.GetComponent<Transform>().position = new Vector3(redSpawn.x, redSpawn.y, redSpawn.z);
            }
        }
        if (yellowStatue.GetComponent<SpriteRenderer>().enabled == false)
        {
            if (yellowPos.y < -15)
            {
                yellowPiece.GetComponent<Transform>().position = new Vector3(yellowSpawn.x, yellowSpawn.y, yellowSpawn.z);
            }
        }
        if (blueStatue.GetComponent<SpriteRenderer>().enabled == false)
        {
            if (bluePos.y < -15)
            {
                bluePiece.GetComponent<Transform>().position = new Vector3(blueSpawn.x, blueSpawn.y, blueSpawn.z);
                bluePiece.GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 82);
            }
        }
    }
}
