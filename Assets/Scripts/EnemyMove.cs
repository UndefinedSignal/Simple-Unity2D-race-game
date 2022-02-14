using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float _speed;
    public bool flip = true;

    // Start is called before the first frame update
    void Start()
    {
        if(flip)
        {
            transform.rotation = Quaternion.AngleAxis(180f, Vector3.forward);
        }
        _speed = Random.Range(5f, 8f);
    }

    // Update is called once per frame
    void Update()
    {
        if(flip)
        {
            transform.Translate(new Vector3(0, 1, 0) * _speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(new Vector3(0, -1, 0) * _speed * Time.deltaTime);
        }
        
    }
}
