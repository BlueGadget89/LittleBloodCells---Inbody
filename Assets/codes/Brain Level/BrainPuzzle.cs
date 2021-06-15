using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//THIS ONE IS FOR HAPPY 
public class BrainPuzzle : MonoBehaviour
{
    public GameObject P1, P2, P3, P4, P5, P6; // puzzle 1,2,3,4,5,6
    public int final = 10,answer = 0;
    public bool P1hit, P2hit, P3hit, P4hit, P5hit, P6hit;
    public GameObject brainGM;
   // public int currentPiece;
    public List<int> contactOrder;
    public List<int> correctOrder;
    public bool happyComplete, angerComplete, fearComplete;
    public GameObject Player;
    public GameObject playerDamage;
    public int wrongOrderCount;
    public GameObject happyFlash, angerFlash, fearFlash;

    // Start is called before the first frame update
    void Start()
    {
        //currentPiece = 1;
        P1 = GameObject.Find("happy1");
        P2 = GameObject.Find("happy2");
        P3 = GameObject.Find("happy3");
        P4 = GameObject.Find("happy4");
        P5 = null;
        P6 = null;
        correctOrder.Add(1);
        correctOrder.Add(2);
        correctOrder.Add(3);
        correctOrder.Add(4);
        wrongOrderCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (brainGM.GetComponent<BrainGM>().emotion == "Happy")
        {
            if (wrongOrderCount >= 2)
            {
                happyFlash.GetComponent<HappyItemFlashScript>().isFlashing = true;
                wrongOrderCount = 0;
            }
            if (P1.GetComponent<Brain_piece_behavior>().onhit == true)
            {
                P1hit = true;
            }
            if (P2.GetComponent<Brain_piece_behavior>().onhit == true)
            {
                P2hit = true;
            }
            if (P3.GetComponent<Brain_piece_behavior>().onhit == true)
            {
                P3hit = true;
            }
            if (P4.GetComponent<Brain_piece_behavior>().onhit == true)
            {
                P4hit = true;
            }
            for (int index = 0; index < contactOrder.Count; index++)
            if (contactOrder[index] != correctOrder[index])
            {
                StartCoroutine(ResetHappyPuzzle());
                wrongOrderCount += 1;
                Player.GetComponent<PlayerMovementScript>().playerHp -= 1;
                //playerDamage.GetComponent<Player_Damage_Script>().gethit = true;
            }
            if (contactOrder.Count == correctOrder.Count)
            {
                happyComplete = true;
                StartCoroutine(transitionToAnger());
            }
        }
        if (brainGM.GetComponent<BrainGM>().emotion == "Anger")
        {
            if (wrongOrderCount >= 2)
            {
                angerFlash.GetComponent<AngerItemFlashScript>().isFlashing = true;
                wrongOrderCount = 0;
            }
            if (P1.GetComponent<Brain_piece_behavior>().onhit == true)
            {
                P1hit = true;
            }
            if (P2.GetComponent<Brain_piece_behavior>().onhit == true)
            {
                P2hit = true;
            }
            if (P3.GetComponent<Brain_piece_behavior>().onhit == true)
            {
                P3hit = true;
            }
            if (P4.GetComponent<Brain_piece_behavior>().onhit == true)
            {
                P4hit = true;
            }
            if (P5.GetComponent<Brain_piece_behavior>().onhit == true)
            {
                P5hit = true;
            }
            for (int index = 0; index < contactOrder.Count; index++)
                if (contactOrder[index] != correctOrder[index])
                {
                    Player.GetComponent<PlayerMovementScript>().playerHp -= 1;
                    //playerDamage.GetComponent<Player_Damage_Script>().gethit = true;
                    wrongOrderCount += 1;
                    StartCoroutine(ResetAngerPuzzle());
                }
            //for (int index = 0; index < contactOrder.Count; index++)
            if (contactOrder.Count == correctOrder.Count)
            {
                angerComplete = true;
               StartCoroutine(transitionToFear());
            }
        }
        if (brainGM.GetComponent<BrainGM>().emotion == "Fear")
        {
            if (wrongOrderCount >= 2)
            {
                fearFlash.GetComponent<FearItemFlashScript>().isFlashing = true;
                wrongOrderCount = 0;
            }
            if (P1.GetComponent<Brain_piece_behavior>().onhit == true)
            {
                P1hit = true;
            }
            if (P2.GetComponent<Brain_piece_behavior>().onhit == true)
            {
                P2hit = true;
            }
            if (P3.GetComponent<Brain_piece_behavior>().onhit == true)
            {
                P3hit = true;
            }
            if (P4.GetComponent<Brain_piece_behavior>().onhit == true)
            {
                P4hit = true;
            }
            if (P5.GetComponent<Brain_piece_behavior>().onhit == true)
            {
                P5hit = true;
            }
            if (P6.GetComponent<Brain_piece_behavior>().onhit == true)
            {
                P6hit = true;
            }
            for (int index = 0; index < contactOrder.Count; index++)
                if (contactOrder[index] != correctOrder[index])
                {
                    Player.GetComponent<PlayerMovementScript>().playerHp -= 1;
                    //playerDamage.GetComponent<Player_Damage_Script>().gethit = true;
                    wrongOrderCount += 1;
                    StartCoroutine(ResetFearPuzzle());
                }
            //for (int index = 0; index < contactOrder.Count; index++)
            if (contactOrder.Count == correctOrder.Count)
            {
                fearComplete = true;
                Debug.Log("Level Complete");
            }
        }

    }

    public IEnumerator ResetHappyPuzzle()
    {
        Debug.Log("Happy Puzzle Reset");
        P1.GetComponent<CircleCollider2D>().enabled = true;
        P1.GetComponent<Rigidbody2D>().simulated = true;
        P2.GetComponent<CircleCollider2D>().enabled = true;
        P2.GetComponent<Rigidbody2D>().simulated = true;
        P3.GetComponent<CircleCollider2D>().enabled = true;
        P3.GetComponent<Rigidbody2D>().simulated = true;
        P4.GetComponent<CircleCollider2D>().enabled = true;
        P4.GetComponent<Rigidbody2D>().simulated = true;
        P1.GetComponent<Brain_piece_behavior>().onhit = false;
        P2.GetComponent<Brain_piece_behavior>().onhit = false;
        P3.GetComponent<Brain_piece_behavior>().onhit = false;
        P4.GetComponent<Brain_piece_behavior>().onhit = false;
        contactOrder.Clear();
        //currentPiece = 1;
        yield return null;
    }
    public IEnumerator ResetAngerPuzzle()
    {
        P1.GetComponent<CircleCollider2D>().enabled = true;
        P1.GetComponent<Rigidbody2D>().simulated = true;
        P2.GetComponent<CircleCollider2D>().enabled = true;
        P2.GetComponent<Rigidbody2D>().simulated = true;
        P3.GetComponent<CircleCollider2D>().enabled = true;
        P3.GetComponent<Rigidbody2D>().simulated = true;
        P4.GetComponent<CircleCollider2D>().enabled = true;
        P4.GetComponent<Rigidbody2D>().simulated = true;
        P5.GetComponent<CircleCollider2D>().enabled = true;
        P5.GetComponent<Rigidbody2D>().simulated = true;
        P1.GetComponent<Brain_piece_behavior>().onhit = false;
        P2.GetComponent<Brain_piece_behavior>().onhit = false;
        P3.GetComponent<Brain_piece_behavior>().onhit = false;
        P4.GetComponent<Brain_piece_behavior>().onhit = false;
        P5.GetComponent<Brain_piece_behavior>().onhit = false;
        contactOrder.Clear();
        //currentPiece = 1;
        yield return null;
    }
    public IEnumerator ResetFearPuzzle()
    {
        P1.GetComponent<CircleCollider2D>().enabled = true;
        P1.GetComponent<Rigidbody2D>().simulated = true;
        P2.GetComponent<CircleCollider2D>().enabled = true;
        P2.GetComponent<Rigidbody2D>().simulated = true;
        P3.GetComponent<CircleCollider2D>().enabled = true;
        P3.GetComponent<Rigidbody2D>().simulated = true;
        P4.GetComponent<CircleCollider2D>().enabled = true;
        P4.GetComponent<Rigidbody2D>().simulated = true;
        P5.GetComponent<CircleCollider2D>().enabled = true;
        P5.GetComponent<Rigidbody2D>().simulated = true;
        P6.GetComponent<CircleCollider2D>().enabled = true;
        P6.GetComponent<Rigidbody2D>().simulated = true;
        P1.GetComponent<Brain_piece_behavior>().onhit = false;
        P2.GetComponent<Brain_piece_behavior>().onhit = false;
        P3.GetComponent<Brain_piece_behavior>().onhit = false;
        P4.GetComponent<Brain_piece_behavior>().onhit = false;
        P5.GetComponent<Brain_piece_behavior>().onhit = false;
        P6.GetComponent<Brain_piece_behavior>().onhit = false;
        //currentPiece = 1;
        yield return null;
    }
    public IEnumerator transitionToAnger()
    {
        contactOrder.Clear();
        correctOrder.Add(5);
        Debug.Log("Transitioning to Anger");
        P1 = GameObject.Find("anger_1");
        P2 = GameObject.Find("anger_2");
        P3 = GameObject.Find("anger_3");
        P4 = GameObject.Find("anger_4");
        P5 = GameObject.Find("anger_5");
        P1.GetComponent<CircleCollider2D>().enabled = true;
        P1.GetComponent<Rigidbody2D>().simulated = true;
        P2.GetComponent<CircleCollider2D>().enabled = true;
        P2.GetComponent<Rigidbody2D>().simulated = true;
        P3.GetComponent<CircleCollider2D>().enabled = true;
        P3.GetComponent<Rigidbody2D>().simulated = true;
        P4.GetComponent<CircleCollider2D>().enabled = true;
        P4.GetComponent<Rigidbody2D>().simulated = true;
        P5.GetComponent<CircleCollider2D>().enabled = true;
        P5.GetComponent<Rigidbody2D>().simulated = true;
        P1.GetComponent<Brain_piece_behavior>().onhit = false;
        P2.GetComponent<Brain_piece_behavior>().onhit = false;
        P3.GetComponent<Brain_piece_behavior>().onhit = false;
        P4.GetComponent<Brain_piece_behavior>().onhit = false;
        P5.GetComponent<Brain_piece_behavior>().onhit = false;
        brainGM.GetComponent<BrainGM>().happyCamera.GetComponent<Camera>().enabled = false;
        brainGM.GetComponent<BrainGM>().playerCamera.GetComponent<Camera>().enabled = true;
        Player.GetComponent<PlayerMovementScript>().Spwan = new Vector3(3, 2, 0);
        yield return null;
    }
    public IEnumerator transitionToFear()
    {
        contactOrder.Clear();
        correctOrder.Add(6);
        P1 = GameObject.Find("Fear1");
        P2 = GameObject.Find("Fear2");
        P3 = GameObject.Find("Fear3");
        P4 = GameObject.Find("Fear4");
        P5 = GameObject.Find("Fear5");
        P6 = GameObject.Find("Fear6");
        Debug.Log("Transitioning to Fear");
        P1.GetComponent<CircleCollider2D>().enabled = true;
        P1.GetComponent<Rigidbody2D>().simulated = true;
        P2.GetComponent<CircleCollider2D>().enabled = true;
        P2.GetComponent<Rigidbody2D>().simulated = true;
        P3.GetComponent<CircleCollider2D>().enabled = true;
        P3.GetComponent<Rigidbody2D>().simulated = true;
        P4.GetComponent<CircleCollider2D>().enabled = true;
        P4.GetComponent<Rigidbody2D>().simulated = true;
        P5.GetComponent<CircleCollider2D>().enabled = true;
        P5.GetComponent<Rigidbody2D>().simulated = true;
        P6.GetComponent<CircleCollider2D>().enabled = true;
        P6.GetComponent<Rigidbody2D>().simulated = true;
        P1.GetComponent<Brain_piece_behavior>().onhit = false;
        P2.GetComponent<Brain_piece_behavior>().onhit = false;
        P3.GetComponent<Brain_piece_behavior>().onhit = false;
        P4.GetComponent<Brain_piece_behavior>().onhit = false;
        P5.GetComponent<Brain_piece_behavior>().onhit = false;
        P6.GetComponent<Brain_piece_behavior>().onhit = false;
        yield return null;
    }
}
