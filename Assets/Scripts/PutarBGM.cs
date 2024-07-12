using UnityEngine;

public class PutarBGM : MonoBehaviour
{
    public AudioClip BGM;

    void Start()
    {
        // Mendapatkan komponen AudioSource
        AudioSource audioSource = GetComponent<AudioSource>();

        // Mengatur file audio yang akan diputar
        audioSource.clip = BGM;

        // Mengatur agar musik diputar secara terus-menerus (looping)
        audioSource.loop = true;

        // Memainkan musik
        audioSource.Play();
    }
}
