using UnityEngine;

public class EngineSoundEmitter : MonoBehaviour
{

    public AudioSource mySource;

    // Start is called before the first frame update

    // Start is called before the first frame update
    void Start()
    {
        mySource = GetComponent<AudioSource>();
    }

    public void Play()
    {
        mySource.Play();
    }
    public void Stop()
    {
        mySource.Stop();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
