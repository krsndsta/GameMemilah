using UnityEngine;
using UnityEngine.UI;

public class DeteksiBuahSayur : MonoBehaviour
{
    public string nameTag;
    public AudioClip audioBenar;
    public AudioClip audioSalah;
    private AudioSource MediaPlayerBenar;
    private AudioSource MediaPlayerSalah;
    public Text textScore;

    // Use this for initialization
    void Start()
    {
        MediaPlayerBenar = gameObject.AddComponent<AudioSource>();
        MediaPlayerBenar.clip = audioBenar;

        MediaPlayerSalah = gameObject.AddComponent<AudioSource>();
        MediaPlayerSalah.clip = audioSalah;
    }

    void Update()
    {
        // Tidak ada kode di sini untuk saat ini
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Pastikan collision tidak null dan memiliki tag yang tidak null sebelum memeriksa tagnya
        if (collision != null && !string.IsNullOrEmpty(collision.tag) && collision.tag.Equals(nameTag))
        {
            Data.score += 1;
            textScore.text = Data.score.ToString();
            Destroy(collision.gameObject);
            MediaPlayerBenar.Play();
        }
        else
        {
            Data.score -= 1;
            textScore.text = Data.score.ToString();
            Destroy(collision.gameObject);
            MediaPlayerSalah.Play();
        }
    }
}
