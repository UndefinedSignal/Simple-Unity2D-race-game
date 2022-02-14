using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float _carSpeed = 5f;
    Rigidbody2D rd;

    public uiController ui;

    //Sound
    public AudioSource mySource;
    public AudioClip[] myAudio;
    public int toPlay;

    private bool buttonMoving = false;

    // Start is called before the first frame update
    void Start()
    {
        mySource = GetComponent<AudioSource>();
        rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -2.2f, 2.2f);

        transform.position = pos;

        if (!buttonMoving)
        {
            float direction = Input.GetAxis("Horizontal");
            ContributeVelocity(direction);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            ui.GameOverTrue();
        }else if (collision.gameObject.tag == "Human")
        {
            ui.AddVenhiclePoint(5);
            Destroy(collision.gameObject);
            toPlay = Random.Range(0, myAudio.Length);
            mySource.PlayOneShot(myAudio[toPlay], 0.9F);
            mySource.Play();
        }
    }

    private void ContributeVelocity(float arg)
    {
        Vector2 carMove = new Vector2(_carSpeed * arg, 0);
        rd.velocity = carMove;
    }

    public void MoveLeft()
    {
        buttonMoving = true;
        ContributeVelocity(-1);
    }

    public void MoveRight()
    {
        buttonMoving = true;
        ContributeVelocity(1);
    }

    public void StopMovement()
    {
        buttonMoving = false;
        rd.velocity = Vector2.zero;
    }
}
