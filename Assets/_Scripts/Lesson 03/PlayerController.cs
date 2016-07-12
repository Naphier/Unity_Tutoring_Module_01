using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))] // can only add this MonoBehaviour component to a game object with an animator!
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Collider2D))]
public class PlayerController : MonoBehaviour
{
    public float moveForce = 10;
    private Animator anim;
    private Rigidbody2D rb2D;
    private SpriteRenderer sr;
    private Collider2D coll2d;
    public float jumpForce = 10;
    private float initialDrag;
	void Start ()
    {
        anim = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        initialDrag = rb2D.drag;
        coll2d = GetComponent<Collider2D>();

	}
	
	
	void FixedUpdate () // best for applying physics -- if applying each frame
    {
        float h = Input.GetAxis("Horizontal");
        Move(h);

        
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            Jump();
    }

    void Move(float inputSpeed)
    {
        if (!grounded || !allowMove)
            return;

        rb2D.AddForce(Vector2.right * inputSpeed * moveForce);

        anim.SetFloat("speed", Mathf.Abs(inputSpeed));
        if (inputSpeed < -0.01f)
            sr.flipX = true;
        else if (inputSpeed > 0.01f)
            sr.flipX = false;
    }

    
    void Jump()
    {
        if (grounded && allowMove)
        {
            rb2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            anim.SetBool("jump", true);
        }
    }

    bool grounded = false;
    
    void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            grounded = true;
            
        }
    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            anim.SetBool("jump", false);
            rb2D.drag = initialDrag;
        }
        else if (coll.gameObject.tag == "Obstacle")
        {
            StartCoroutine(DieCoroutine());
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "checkpoint")
        {
            gameController.SetLastCheckpoint(other.transform);
        }
    }


    void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            grounded = false;
            rb2D.drag = 0.5f * initialDrag;
        }
    }

    bool allowMove = true;
    IEnumerator DieCoroutine()
    {
        allowMove = false;
        
        rb2D.AddForce(Vector2.up * jumpForce * 0.5f, ForceMode2D.Impulse);
        anim.SetBool("jump", false);
        anim.SetFloat("speed", 0);
        anim.SetBool("hurt", true);
        coll2d.enabled = false;

        bool toggle = false;
        for (int i = 0; i < 16; i++)
        {
            if (toggle)
                sr.color = Color.red;
            else
                sr.color = Color.white;
            toggle = !toggle;
            yield return new WaitForSeconds(0.25f);
        }
        sr.color = Color.white;

        rb2D.velocity = Vector2.zero;
        //GameController gc = GameObject.FindObjectOfType<GameController>();
        //gc.Restart();
        gameController.Restart();
    }

    GameController _gameController = null;
    GameController gameController
    {
        get
        {
            if (_gameController == null)
            {
                _gameController = GameObject.FindObjectOfType<GameController>();
            }

            return _gameController;
        }
    }

    public void Reset()
    {
        allowMove = true;
        coll2d.enabled = true;
        anim.SetBool("hurt", false);
    }
}
