using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{ // to see which token is colliding with the hole and changing the points for every player and from here we are updating the points method
    public  RightMouse RM ;
    public bool goal;
    public GameObject ST;
    public GameObject RedToken;
        void Start()
    {
        goal = false;
        ST=GameObject.FindGameObjectWithTag("Striker");
    }
    void Update()
    {
        RedToken.GetComponent<Transform>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "RedToken")
        {
            if (RM.i < 18)
            {
                RedToken.transform.position = GameObject.FindGameObjectWithTag("centerPoint").transform.position;
                goal = true;
                RM.n++;
                RM.i += 0;
                RM.n = RM.playerTurnPoint(0, RM.OldScoreplayers);
                Debug.Log("After method PlayerTurn in Script Hole work Hello 0 and put the red token in the middel");
                RM.myRigidbody2D.velocity = Vector2.zero;
                Debug.Log("After RM velocity in script Hole RED Token ");
                RM.selectArea = true;
                Debug.Log("After collution i is = " + RM.i);           
            }
            else
            {
                goal = true;
                RM.n = RM.playerTurnPoint(25, RM.OldScoreplayers);
                Debug.Log("After method PlayerTurn in Script Hole work Hello 25");
                RM.myRigidbody2D.velocity = Vector2.zero;
                Debug.Log("After RM velocity in script Hole RED Token ");
                RM.selectArea = true;
                collision.gameObject.SetActive(false);
                Debug.Log("After collution i is = " + RM.i);
                Destroy(collision.collider.gameObject);
            }
        }
        if (collision.gameObject.tag == "BlackToken")
        {
            goal = true;
            RM.n = RM.playerTurnPoint(5, RM.OldScoreplayers);
            Debug.Log("After method PlayerTurn in Script Hole work Hello 25");
            RM.myRigidbody2D.velocity = Vector2.zero;
            Debug.Log("After RM velocity in script Hole BLACK TOKEN ");
            RM.selectArea = true;
            collision.gameObject.SetActive(false);
            Destroy(collision.collider.gameObject);
            Debug.Log("After collution i is = " + RM.i);
        }
        if (collision.gameObject.tag == "WhiteToken")
        {
            goal = true;
            RM.n = RM.playerTurnPoint(10, RM.OldScoreplayers);
            Debug.Log("After method PlayerTurn in Script Hole work Hello 25");
            RM.myRigidbody2D.velocity = Vector2.zero;
            Debug.Log("After RM velocity in script Hole WHITE TOKEN ");
            RM.selectArea = true;
            collision.gameObject.SetActive(false);
            Destroy(collision.collider.gameObject);
            Debug.Log("After collution i is = " + RM.i);
        }
        else
        {
            goal = !goal;
        }
    }
}
