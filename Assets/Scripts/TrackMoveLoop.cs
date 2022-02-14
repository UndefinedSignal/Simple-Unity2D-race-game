using UnityEngine;

public class TrackMoveLoop : MonoBehaviour
{

    public float _speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(0, Time.time * _speed);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
