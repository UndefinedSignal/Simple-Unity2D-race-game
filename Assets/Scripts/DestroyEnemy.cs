using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public float scoreOnDestroy = 2;

    public uiController ui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            ui.AddVenhiclePoint(scoreOnDestroy);
            Destroy(collision.gameObject);
        }else if(collision.gameObject.tag == "Human")
        {
            Destroy(collision.gameObject);
        }
    }
}
