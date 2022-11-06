using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicTacToe : MonoBehaviour
{
    public string[,] TicTacToeArray = new string[,]{{"1","1","1"},{"1","1","1"},{"1","1","1"}};

    public GameObject tictactoeButton00 = new GameObject();
    public GameObject tictactoeButton01 = new GameObject();
    public GameObject tictactoeButton02 = new GameObject();
    public GameObject tictactoeButton10 = new GameObject();
    public GameObject tictactoeButton11 = new GameObject();
    public GameObject tictactoeButton12 = new GameObject();
    public GameObject tictactoeButton20 = new GameObject();
    public GameObject tictactoeButton21 = new GameObject();
    public GameObject tictactoeButton22 = new GameObject();

    public GameObject X = new GameObject();
    public GameObject O = new GameObject();

    //public GameObject message;
    //public GameObject PlayAgain;

    bool gameEnd;

    int turn = 0;
    // Start is called before the first frame update
    void Start()
    {
        //message.SetActivity(false);
        //PlayAgain.SetActivity(false);
        gameEnd=false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameEnd)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                if (hit.transform.name == tictactoeButton00.name){
                    if(turn % 2 == 0){
                        TicTacToeArray[0,0]= "X";
                        turn ++;
                        Instantiate(X, new Vector3(tictactoeButton00.transform.position.x, tictactoeButton00.transform.position.y,tictactoeButton00.transform.position.z),Quaternion.identity);

                    }else {
                        TicTacToeArray[0,0]= "O";
                        turn ++;
                        Instantiate(O, new Vector3(tictactoeButton00.transform.position.x, tictactoeButton00.transform.position.y,tictactoeButton00.transform.position.z),Quaternion.identity);

                    }
                    checkWinner();
                }
                else if (hit.transform.name == tictactoeButton01.name){
                    if(turn % 2 == 0){
                        TicTacToeArray[0,1]= "X";
                        turn ++;
                        Instantiate(X, new Vector3(tictactoeButton01.transform.position.x, tictactoeButton01.transform.position.y,tictactoeButton01.transform.position.z),Quaternion.identity);

                    }else {
                        TicTacToeArray[0,1]= "O";
                        turn ++;
                        Instantiate(O, new Vector3(tictactoeButton01.transform.position.x, tictactoeButton01.transform.position.y,tictactoeButton01.transform.position.z),Quaternion.identity);

                    }
                    checkWinner();
                }
                else if (hit.transform.name == tictactoeButton02.name){
                    if(turn % 2 == 0){
                        TicTacToeArray[0,2]= "X";
                        turn ++;
                        Instantiate(X, new Vector3(tictactoeButton02.transform.position.x, tictactoeButton02.transform.position.y,tictactoeButton02.transform.position.z),Quaternion.identity);

                    }else {
                        TicTacToeArray[0,2]= "O";
                        turn ++;
                        Instantiate(O, new Vector3(tictactoeButton02.transform.position.x, tictactoeButton02.transform.position.y,tictactoeButton02.transform.position.z),Quaternion.identity);

                    }
                    checkWinner();
                }
                else if (hit.transform.name == tictactoeButton10.name){
                    if(turn % 2 == 0){
                        TicTacToeArray[1,0]= "X";
                        turn ++;
                        Instantiate(X, new Vector3(tictactoeButton10.transform.position.x, tictactoeButton10.transform.position.y,tictactoeButton10.transform.position.z),Quaternion.identity);

                    }else {
                        TicTacToeArray[1,0]= "O";
                        turn ++;
                        Instantiate(O, new Vector3(tictactoeButton10.transform.position.x, tictactoeButton10.transform.position.y,tictactoeButton10.transform.position.z),Quaternion.identity);

                    }
                    checkWinner();
                }
                else if (hit.transform.name == tictactoeButton11.name){
                    if(turn % 2 == 0){
                        TicTacToeArray[1,1]= "X";
                        turn ++;
                        Instantiate(X, new Vector3(tictactoeButton11.transform.position.x, tictactoeButton11.transform.position.y,tictactoeButton11.transform.position.z),Quaternion.identity);

                    }else {
                        TicTacToeArray[1,1]= "O";
                        turn ++;
                        Instantiate(O, new Vector3(tictactoeButton11.transform.position.x, tictactoeButton11.transform.position.y,tictactoeButton11.transform.position.z),Quaternion.identity);

                    }
                    checkWinner();
                }
                else if (hit.transform.name == tictactoeButton12.name){
                    if(turn % 2 == 0){
                        TicTacToeArray[1,2]= "X";
                        turn ++;
                        Instantiate(X, new Vector3(tictactoeButton12.transform.position.x, tictactoeButton12.transform.position.y,tictactoeButton12.transform.position.z),Quaternion.identity);

                    }else {
                        TicTacToeArray[1,2]= "O";
                        turn ++;
                        Instantiate(O, new Vector3(tictactoeButton12.transform.position.x, tictactoeButton12.transform.position.y,tictactoeButton12.transform.position.z),Quaternion.identity);

                    }
                    checkWinner();
                }
                else if (hit.transform.name == tictactoeButton20.name){
                    if(turn % 2 == 0){
                        TicTacToeArray[2,0]= "X";
                        turn ++;
                        Instantiate(X, new Vector3(tictactoeButton20.transform.position.x, tictactoeButton20.transform.position.y,tictactoeButton20.transform.position.z),Quaternion.identity);

                    }else {
                        TicTacToeArray[2,0]= "O";
                        turn ++;
                        Instantiate(O, new Vector3(tictactoeButton20.transform.position.x, tictactoeButton20.transform.position.y,tictactoeButton20.transform.position.z),Quaternion.identity);

                    }
                    checkWinner();
                }
                else if (hit.transform.name == tictactoeButton21.name){
                    if(turn % 2 == 0){
                        TicTacToeArray[2,1]= "X";
                        turn ++;
                        Instantiate(X, new Vector3(tictactoeButton21.transform.position.x, tictactoeButton21.transform.position.y,tictactoeButton21.transform.position.z),Quaternion.identity);

                    }else {
                        TicTacToeArray[2,1]= "O";
                        turn ++;
                        Instantiate(O, new Vector3(tictactoeButton21.transform.position.x, tictactoeButton21.transform.position.y,tictactoeButton21.transform.position.z),Quaternion.identity);

                    }
                    checkWinner();
                }
                else if (hit.transform.name == tictactoeButton22.name){
                    if(turn % 2 == 0){
                        TicTacToeArray[2,2]= "X";
                        turn ++;
                        Instantiate(X, new Vector3(tictactoeButton22.transform.position.x, tictactoeButton22.transform.position.y,tictactoeButton22.transform.position.z),Quaternion.identity);

                    }else {
                        TicTacToeArray[2,2]= "O";
                        turn ++;
                        Instantiate(O, new Vector3(tictactoeButton22.transform.position.x, tictactoeButton22.transform.position.y,tictactoeButton22.transform.position.z),Quaternion.identity);

                    }
                    checkWinner();
                }
                
                
            }
        }
        
    }
    public void checkWinner()
    {
        if((TicTacToeArray[0,0]=="O" && TicTacToeArray[0,1]=="O" && TicTacToeArray[0,2]=="O") || 
        (TicTacToeArray[0,0]=="O" && TicTacToeArray[0,1]=="O" && TicTacToeArray[0,2]=="O") ||
        (TicTacToeArray[0,0]=="O" && TicTacToeArray[0,1]=="O" && TicTacToeArray[0,2]=="O") || 
        (TicTacToeArray[0,0]=="O" && TicTacToeArray[0,1]=="O" && TicTacToeArray[0,2]=="O") ||
        (TicTacToeArray[0,0]=="O" && TicTacToeArray[0,1]=="O" && TicTacToeArray[0,2]=="O") ||
        (TicTacToeArray[0,0]=="O" && TicTacToeArray[0,1]=="O" && TicTacToeArray[0,2]=="O") ||
        (TicTacToeArray[0,0]=="O" && TicTacToeArray[0,1]=="O" && TicTacToeArray[0,2]=="O") ||
        (TicTacToeArray[0,0]=="O" && TicTacToeArray[0,1]=="O" && TicTacToeArray[0,2]=="O") )
        {
            //PlayAgain.SetActivity(true);
            //message.SetActivity(true);
            //message.text= "Winner is O";
            gameEnd=true;
        }
        else if((TicTacToeArray[0,0]=="O" && TicTacToeArray[0,1]=="O" && TicTacToeArray[0,2]=="O") || 
        (TicTacToeArray[0,0]=="O" && TicTacToeArray[0,1]=="O" && TicTacToeArray[0,2]=="O") ||
        (TicTacToeArray[0,0]=="O" && TicTacToeArray[0,1]=="O" && TicTacToeArray[0,2]=="O") || 
        (TicTacToeArray[0,0]=="O" && TicTacToeArray[0,1]=="O" && TicTacToeArray[0,2]=="O") ||
        (TicTacToeArray[0,0]=="O" && TicTacToeArray[0,1]=="O" && TicTacToeArray[0,2]=="O") ||
        (TicTacToeArray[0,0]=="O" && TicTacToeArray[0,1]=="O" && TicTacToeArray[0,2]=="O") ||
        (TicTacToeArray[0,0]=="O" && TicTacToeArray[0,1]=="O" && TicTacToeArray[0,2]=="O") ||
        (TicTacToeArray[0,0]=="O" && TicTacToeArray[0,1]=="O" && TicTacToeArray[0,2]=="O") )
        {
            //PlayAgain.SetActivity(true);
            //message.SetActivity(true);
            //message.text= "Winner is X";
            gameEnd=true;

        }
    }
    public void PA()
    {
        TicTacToeArray = new string[,]{{"1","1","1"},{"1","1","1"},{"1","1","1"}};
        turn = 0;
        //GameObject go = GameObject.find("X(Clone)");
        //Destroy(go);

    }
}
