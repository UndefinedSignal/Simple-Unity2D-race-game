using UnityEngine;

public class HumanSpawner : MonoBehaviour
{
    public GameObject[] humans;

    public float _maxTimer = 2f;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Vector3 pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            int enemyId = Random.Range(0, humans.Length);

            Instantiate(humans[enemyId], pos, transform.rotation);
            timer = Random.Range(1, _maxTimer);
        }
    }
}
