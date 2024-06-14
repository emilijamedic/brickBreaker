using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BallScript : MonoBehaviour
{
public Rigidbody2D rb;
// Start is called before the first frame update
void Start()
{
}
// Update is called once per frame
void Update()
{
Movement();
}
void Movement()
{
if (GameManager.startGame == true && GameManager.gameStarted == false)
{
rb.AddForce(transform.up * 250f);
rb.AddForce(transform.right * -250f);
GameManager.gameStarted = true;
}
if (rb.velocity.x < 1 && rb.velocity.x >= 0)
{
rb.AddForce(transform.right * -50f);
}
if (rb.velocity.x > -1 && rb.velocity.x < 0)
{
rb.AddForce(transform.right * 50f);
}
if (rb.velocity.y < 1 && rb.velocity.y >= 0)
{
rb.AddForce(transform.up * -50f);
}
if (rb.velocity.y > -1 && rb.velocity.y < 0)
{
rb.AddForce(transform.up * 50f);
}
}

private void OnCollisionEnter2D(Collision2D collision)
{
if (collision.gameObject.tag == "Brick")
{
Destroy(collision.gameObject);
}
if (collision.gameObject.tag == "LoseBox")
{
Destroy(this.gameObject);
}
}
}
