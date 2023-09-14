using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{
    public float speed = 5f;
    public float jumpPower = 5f;
    public int id;
    float MoveX;
    float MoveX2;
    Rigidbody2D rb;
    int jumpCount = 0;
    int jumpCountMax = 1;
    public GameObject P1_Wall, P2_Wall;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (id == 1)
        {
            MoveX = Input.GetAxisRaw("Horizontal");
            rb.velocity = new Vector2(MoveX * speed, rb.velocity.y);
            if (MoveX > 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            else if (MoveX < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }

            if (Input.GetKeyDown(KeyCode.Space)|| Input.GetKeyDown(KeyCode.W))
            {
                if (jumpCount < jumpCountMax)
                {
                    rb.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
                    jumpCount++;
                }
            }
        }
        if (id == 2)
        {
            MoveX2 = Input.GetAxisRaw("Horizontal2");
            rb.velocity = new Vector2(MoveX2 * speed, rb.velocity.y);
            if (MoveX2 > 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            else if (MoveX2 < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (jumpCount < jumpCountMax)
                {
                    rb.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
                    jumpCount++;
                }
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumpCount = 0;
        if(collision.gameObject.tag == "Spikes")
        {
            GameObject Ui = GameObject.Find("Death");
            Ui.GetComponent<Death>().Death_Player();
        }
    }
}
