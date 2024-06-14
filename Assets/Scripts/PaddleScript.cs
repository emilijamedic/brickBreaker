

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PaddleScript : MonoBehaviour
{
public Camera mainCamera;
private float leftMax = 100f;
private float rightMax = 700f;

void Start()
{
mainCamera = FindObjectOfType<Camera>();
}
void Update()
{
Movement();
}
void Movement()
{
float maxMovement = Mathf.Clamp(Input.mousePosition.x, leftMax, rightMax);
// Debug.Log(maxMovement);
float worldXposition = mainCamera.ScreenToWorldPoint(
new Vector3(maxMovement, 0, 0)).x;
this.transform.position = new Vector3(worldXposition, this.transform.position.y ,0);}
}