using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
private BallScript intitialBall;
public BallScript ballPrefab;
public PaddleScript paddle;
public static bool startGame;
public static bool gameStarted;
public int count;
public Text endScreen;

void Start()
{
InitializeBall();
}
void Update()
{
YouWin();
YouLose();
PreStartGame();
}
void PreStartGame()
{
Vector3 paddlePosition = paddle.gameObject.transform.position;
Vector3 ballPosition = new Vector3(paddlePosition.x, paddlePosition.y + 0.5f, 0);
if (Input.GetMouseButtonDown(0))
{
startGame = true;
}
if (!startGame)
{
intitialBall.transform.position = ballPosition;
}
}

void InitializeBall()
{
Vector3 paddlePosition = paddle.gameObject.transform.position;
Vector3 ballPosition = new Vector3(paddlePosition.x, paddlePosition.y + 0.5f, 0);
intitialBall = Instantiate(ballPrefab, ballPosition, Quaternion.identity);
}
void YouLose()
{
if (intitialBall == null && count > 0)
{
endScreen.text = "You Lose";
}
}
void YouWin()
{
GameObject[] blocks;
blocks = GameObject.FindGameObjectsWithTag("Brick");
count = blocks.Length;
if (count == 0)
{
endScreen.text = "You win";
}
}
}

