using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMAlwaysOn : MonoBehaviour
{
    private static BGMAlwaysOn instance;
    public AudioClip backgroundMusic;
    private AudioSource audioSource;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = backgroundMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Gameplay")
        {
            // Menghentikan musik jika masuk ke scene Gameplay
            audioSource.Stop();
        }
        else if (scene.name == "MainMenu")
        {
            // Memulai kembali musik jika kembali ke Main Menu
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }
}
