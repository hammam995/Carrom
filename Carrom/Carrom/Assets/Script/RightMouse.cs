using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RightMouse : MonoBehaviour
{ 
    private Vector3 mousePosition; // variable to take mouse position
    Vector3 direction; // to take the direction when we aim
    public float moveSpeed = 0.1f; // the speed of the token when it is following the mouse
    public float shootPower = 10f; // the messurment of the power when we shoot
    public float tiempo  = 0; // it is a timer in case the token did'nt stop after the shooting
    private float myFloat = 0; // the time will start from 0
    public int[] players; // array having each pllayer values n is the player number and the value inside it is the player score (the new array)
    public int[] OldScoreplayers; // other array to coppy the value and to messuere the if there is a deffrence between it and betwwen the new array (the old array)
    public int n; // to decide the number of the player (who is playing)
    public int point; // to decide the quantity of the goal (0,5,10,25)
    public int i = 0; // to decide when we enter the red token if it reach 18 (if it is 19 it is means we finish the game we enter all the tokens) (if we enter the red token i will not increase it will be the same)
    public int WinnerPoints; // to write the winner points after we do comparings between the array value
    public int WinnerPn; // to print the winner number numbrt
    public int tiempoEntreMens = 5; // the time that which we enter it , and iit does not matter if we change it
    private int transcurrido = 0; // the counter or the pinter which is i
    public bool selectArea; // to put the condition for the stage of selecting area and shooting 
    public bool ShootStage; // to move to the shoot stage
    public bool shootR; // to check after we shoot 
    public bool TimOn;
    public Rigidbody2D myRigidbody2D; // to take the rigid body and from it the velocity of the tokken
    //the next transforms are to take and put the selecting area for each player
    public Transform ObjectRightPlayer1;
    public Transform ObjectLeftPlayer1;
    public Transform ObjectDownPlayer2;
    public Transform ObjectUpPlayer2;
    public Transform ObjectRightPlayer3;
    public Transform ObjectLeftPlayer3;
    public Transform ObjectDownPlayer4;
    public Transform ObjectUpPlayer4;
    public Transform StrikerPos; 
    public Hole Holee;
    float t;
    // the next Texts are to show each player score and the winner
    public Text player1score;
    public Text Player2Score;
    public Text Player3Score;
    public Text Player4Score;
    public Text TheWinner;
    public GameObject WinnerPanel; // to make the winner panel appear
    public GameObject Board; 
    // Start is called before the first frame update
    private void Awake()
    {
        WinnerPanel.SetActive(false);
    }
    void Start()
    {
        selectArea = true;
        myRigidbody2D = GetComponent<Rigidbody2D>();
        n = 1;
        players = new int [6]; // the new score after shooting
        OldScoreplayers = new int[6]; // the old score before shooting
        ShootStage = false;
        shootR = false; // shot relese
    }
    void Update()
    {
       switch (n)
        {
            case 1 :
                player1score.text = "P1\n" + OldScoreplayers[1];
                if (selectArea )
                {
                    ShootStage = false;
                    shootR = false;
                    followMouseP1();
                }
                else if ( selectArea == false && n==1)
                {
                    Shoot();
                    if (shootR)
                    {
                        Timer();
                        Debug.Log("timer after update");
                        Debug.Log("Update work shoot");
                        if (myRigidbody2D.velocity.x == 0 & myRigidbody2D.velocity.y == 0)
                        {
                            Debug.Log("Entering Velocity Zero");
                            if (OldScoreplayers[n] == players[n])
                            {
                                Debug.Log("Player 1 After comparing between 2 arrays and they are equal we n++");
                                Debug.Log("After comparing between 2 arrays and they are equal we n++");
                                n++;
                                gameObject.transform.position = GameObject.FindGameObjectWithTag("P2").transform.position;
                                //transform.position = GameObject.FindGameObjectWithTag("P2").gameObject.transform.position;
                                selectArea = !selectArea;
                            }
                        }
                    }
                }
                break;
            case 2:
                Player2Score.text = "P2\n" + OldScoreplayers[2];

                if (selectArea )
                {
                    ShootStage = false;
                    shootR = false;
                    followMouseP2();
                }
                else if (selectArea==false && n==2)
                {
                    Shoot();
                    if (shootR)
                    {
                        Timer();
                        Debug.Log("timer after update");
                        Debug.Log("Update work shoot for Player2");
                        if (myRigidbody2D.velocity.x == 0 & myRigidbody2D.velocity.y == 0)
                        {
                            Debug.Log("Entering Velocity Zero for Player2");
                            if (OldScoreplayers[n] == players[n])
                            {
                                Debug.Log("Player 2 After comparing between 2 arrays and they are equal we n++");
                                Debug.Log("After comparing between 2 arrays and they are equal we n++");
                                n++;
                                gameObject.transform.position = GameObject.FindGameObjectWithTag("P3").transform.position;

                                selectArea = !selectArea;
                            }
                        }
                    }
                }
                break;
            case 3:
                Player3Score.text = "P3\n" + OldScoreplayers[3];
                if (selectArea)
                {
                    ShootStage = false;
                    shootR = false;
                    followMouseP3();
                }
                else if (selectArea == false && n == 3)
                {
                    Shoot();
                    if (shootR)
                    {
                        Timer();
                        Debug.Log("timer after update");
                        Debug.Log("Update work shoot for Player3");
                        if (myRigidbody2D.velocity.x == 0 & myRigidbody2D.velocity.y == 0)
                        {
                            Debug.Log("Entering Velocity Zero for Player3");
                            if (OldScoreplayers[n] == players[n])
                            {
                                Debug.Log("Player 3 After comparing between 2 arrays and they are equal we n++");
                                Debug.Log("After comparing between 2 arrays and they are equal we n++");
                                n++;
                                gameObject.transform.position = GameObject.FindGameObjectWithTag("P4").transform.position;
                                selectArea = !selectArea;
                            }
                        }
                    }
                }
                break;
            case 4:
                Player4Score.text = "P4\n" + OldScoreplayers[4];
                if (selectArea )
                {
                    ShootStage = false;
                    shootR = false;
                    followMouseP4();
                }
                else if (selectArea == false && n == 4)
                {
                    Shoot();
                    if (shootR)
                    {
                        Timer();
                        Debug.Log("timer after update");
                        Debug.Log("Update work shoot for Player4");
                        if (myRigidbody2D.velocity.x == 0 & myRigidbody2D.velocity.y == 0) // myRigidbody2D.velocity == Vector2.zero
                        {
                            Debug.Log("Entering Velocity Zero for Player4");
                            if (OldScoreplayers[n] == players[n])
                            {
                                Debug.Log("Player 4 After comparing between 2 arrays and they are equal we n++");
                                Debug.Log("After comparing between 2 arrays and they are equal we n++");
                                n++;
                                gameObject.transform.position = GameObject.FindGameObjectWithTag("P1").transform.position;
                                selectArea = !selectArea;
                            }
                        }
                    }
                }
                break;
            case 5:
                n = 1;
                break;
        }
    }
    public void Timer() // is timer to controll the token in case he didn't stop
    {
        myFloat += Time.deltaTime;
        if (myFloat >= 1)    // in each seccond we will check enter to see the condition
        {
            // Debug.Log(transcurrido);
            if (transcurrido == tiempoEntreMens)
            {
                Debug.Log("the time is equals it is 5 for player n is  " + n);
                myRigidbody2D.velocity = Vector2.zero;
                Debug.Log("the velocit after the time is   " + myRigidbody2D.velocity);
                transcurrido = 0; //make the pointer 0 to reset it
                return; /// it will return to the first if
            }
            transcurrido++;
            Debug.Log("transcurrido is ++ is" + transcurrido);
            myFloat = 0; //we will reset it because the transcurrido here will count the secconds assummed
        }
    }
    public void Shoot() // to controll the shooting stage when we press on the mouse
    {
        if (ShootStage)
        {
            if (Input.GetMouseButton(0))
            {
                mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                direction = StrikerPos.position - mousePosition;
                Debug.Log("hold");
            }
            if (Input.GetMouseButtonUp(0))
            {
                myRigidbody2D.AddForce(direction * shootPower, ForceMode2D.Impulse);
                Debug.Log("After shoot the token");
                shootR = true;
                //Timer(5);
                Debug.Log("timer in shoot method");
                ShootStage = !ShootStage;
            }
        }
    }
    // every FollomousePn is to make the token follow the mouse in seecting area stage before the shooting
    public void followMouseP1()
    {
        Debug.Log("follow mouse p1");
        if (myRigidbody2D.velocity.x != 0 && myRigidbody2D.velocity.y != 0)
        {
            Debug.Log("in the condition in follow mouse p1");
            gameObject.transform.position = GameObject.FindGameObjectWithTag("P1").transform.position;
        }
        Debug.Log("after the condition in follow mouse p1");

        if (myRigidbody2D.velocity.x == 0 && myRigidbody2D.velocity.y == 0)
        {
            if (Input.GetMouseButton(0)) 
            {
                mousePosition = Input.mousePosition;
                mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
                transform.position = Vector2.Lerp(transform.position, new Vector2(Mathf.Clamp(mousePosition.x, ObjectLeftPlayer1.position.x, ObjectRightPlayer1.position.x), Mathf.Clamp(mousePosition.y, ObjectRightPlayer1.transform.position.y, ObjectLeftPlayer1.transform.position.y)), moveSpeed); // make the current object move and follow the mouse by usin learp function
            }
            if (Input.GetMouseButtonUp(0))
            {
                selectArea = !selectArea;
                ShootStage = !ShootStage;
            }
        }
    }

    public void followMouseP2()
    {
        Debug.Log("follow mouse p2");
        if (myRigidbody2D.velocity.x != 0 && myRigidbody2D.velocity.y != 0)
        {
            Debug.Log("in the condition in follow mouse p2");
            gameObject.transform.position = GameObject.FindGameObjectWithTag("P2").transform.position;
        }
        Debug.Log("after the condition in follow mouse p2");
        if (myRigidbody2D.velocity.x == 0 && myRigidbody2D.velocity.y == 0)
        {
            if (Input.GetMouseButton(0)) 
            {
                mousePosition = Input.mousePosition;
                mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
                transform.position = Vector2.Lerp(transform.position, new Vector2(Mathf.Clamp(mousePosition.x, ObjectDownPlayer2.position.x, ObjectUpPlayer2.position.x), Mathf.Clamp(mousePosition.y, ObjectDownPlayer2.transform.position.y, ObjectUpPlayer2.transform.position.y)), moveSpeed); // make the current object move and follow the mouse by usin learp function
            }
            if (Input.GetMouseButtonUp(0))
            {
                selectArea = !selectArea;
                ShootStage = !ShootStage;
            }
        }
    }
    public void followMouseP3()
    {
        Debug.Log("follow mouse p3");
        if (myRigidbody2D.velocity.x != 0 && myRigidbody2D.velocity.y != 0)
        {
            Debug.Log("in the condition in follow mouse p3");
            gameObject.transform.position = GameObject.FindGameObjectWithTag("P3").transform.position;
        }
        Debug.Log("after the condition in follow mouse p3");
        if (myRigidbody2D.velocity.x == 0 && myRigidbody2D.velocity.y == 0)
        {
            if (Input.GetMouseButton(0)) 
            {
                mousePosition = Input.mousePosition;
                mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
                transform.position = Vector2.Lerp(transform.position, new Vector2(Mathf.Clamp(mousePosition.x, ObjectLeftPlayer3.position.x, ObjectRightPlayer3.position.x), Mathf.Clamp(mousePosition.y, ObjectRightPlayer3.transform.position.y, ObjectLeftPlayer3.transform.position.y)), moveSpeed); // make the current object move and follow the mouse by usin learp function
            }
            if (Input.GetMouseButtonUp(0))
            {
                selectArea = !selectArea;
                ShootStage = !ShootStage;
            }
        }
    }
    public void followMouseP4()
    {
        Debug.Log("follow mouse p4");
        if (myRigidbody2D.velocity.x != 0 && myRigidbody2D.velocity.y != 0)
        {
            Debug.Log("in the condition in follow mouse p4");
            gameObject.transform.position = GameObject.FindGameObjectWithTag("P4").transform.position;
        }
        Debug.Log("after the condition in follow mouse p4");
        if (myRigidbody2D.velocity.x == 0 && myRigidbody2D.velocity.y == 0)
        {
            if (Input.GetMouseButton(0))
            {
                mousePosition = Input.mousePosition;
                mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
                transform.position = Vector2.Lerp(transform.position, new Vector2(Mathf.Clamp(mousePosition.x, ObjectDownPlayer4.position.x, ObjectUpPlayer4.position.x), Mathf.Clamp(mousePosition.y, ObjectDownPlayer4.transform.position.y, ObjectUpPlayer4.transform.position.y)), moveSpeed); // make the current object move and follow the mouse by usin learp function
            }
            if (Input.GetMouseButtonUp(0))
            {
                selectArea = !selectArea;
                ShootStage = !ShootStage;
            }
        }
    }
    
    public int playerTurnPoint(int p ,  int [] OldScoreplayers) // it is to calculate the points for the player when the token collide with the hole
    {
        OldScoreplayers[n] = this.OldScoreplayers[n];
        switch (n)
        {
            case 1:
                 point = players[1];
                point +=p;
                players[1] = point;
                Debug.Log("player scored "+p);
                Debug.Log("points for player one is   " + players[1]);
                counter(i++, p);
                if (p == 0)
                {
                    i--;
                }
                gameObject.transform.position = GameObject.FindGameObjectWithTag("P1").transform.position;
                break;
            case 2:
                point = players[2];
                point += p;
                players[2] = point;
                Debug.Log("player scored " + p);
                Debug.Log("points for player 2 is   " + players[2]);
                counter(i++, p);
                if (p == 0)
                {
                    i--;
                }
                gameObject.transform.position = GameObject.FindGameObjectWithTag("P2").transform.position;
                break;
            case 3:
                point = players[3];
                point += p;
                players[3] = point;
                Debug.Log("player scored " + p);
                Debug.Log("points for player 3 is   " + players[3]);
                counter(i++, p);
                if (p == 0)
                {
                    i--;
                }
                gameObject.transform.position = GameObject.FindGameObjectWithTag("P3").transform.position;
                break;
            case 4:
                point = players[4];
                point += p;
                players[4] = point;
                Debug.Log("player scored " + p);
                Debug.Log("points for player 4 is   " + players[4]);
                counter(i++, p);
                if (p == 0)
                {
                    i--;
                }
                gameObject.transform.position = GameObject.FindGameObjectWithTag("P4").transform.position;
                break;
        }
        OldScoreplayers[n] = players[n];
        this.OldScoreplayers[n] = OldScoreplayers[n];
        if (i == 19)
        {
            thewinner(this.OldScoreplayers);
        }
        // we do method for comparing between the array we call it her it take array and we see it is values
        return n;
    }
    public int counter (int i ,int p ) // to controll the i the counter of the tokens in the field
    {
        i = i;
        p = p;
        Debug.Log("counter have been increased by 1 after the goal i = " + i);
        Debug.Log("points are " + p);
        return i;
    }
    public void thewinner(int [] OldScoreplayers) //to show the winner
    {
        int Wscore = OldScoreplayers[0];
        int pw = 0;
        for(int j =0; j<OldScoreplayers.Length; j++)
        {
            if(OldScoreplayers[j]> Wscore)
            {
                Wscore = OldScoreplayers[j];
                pw = j;
            }
        }
        Debug.Log("Winner score is = " + Wscore + "  the player who won is P" + pw);
        WinnerPoints = Wscore;
        WinnerPn = pw;
        Board.SetActive(false);
        WinnerPanel.SetActive(true);
    }
    // to return n
    public int pt(int pn)
    {
        n = pn;
        return n;
    }
    IEnumerator Wait(float duration)
    {
        //This is a coroutine
        Debug.Log("Start Wait() function. The time is: " + Time.time);
        Debug.Log("Float duration = " + duration);
        yield return new WaitForSeconds(duration);   //Wait
        myRigidbody2D.velocity = new Vector2(0, 0);
        Debug.Log("the velocity is:  " + myRigidbody2D.velocity );
        Debug.Log("End Wait() function and the time is: " + Time.time);
    }
    
}
