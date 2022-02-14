using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;

    public float delayTimer = 2f;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Vector3 pos = new Vector3(Random.Range(-2.2f, 2.3f), transform.position.y, transform.position.z);
            int enemyId = Random.Range(0, enemies.Length);

            Instantiate(enemies[enemyId], pos, transform.rotation);
            timer = delayTimer;
        }
    }
}
