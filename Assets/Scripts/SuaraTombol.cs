using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Button))]
public class SuaraTombol : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    public AudioClip suaraHover;
    public AudioClip suaraTekan;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (suaraHover != null)
        {
            audioSource.PlayOneShot(suaraHover);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (suaraTekan != null)
        {
            audioSource.PlayOneShot(suaraTekan);
        }
    }
}
