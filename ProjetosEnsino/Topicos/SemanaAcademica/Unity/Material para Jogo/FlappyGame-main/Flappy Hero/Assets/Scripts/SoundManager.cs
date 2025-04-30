using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [SerializeField]
    private AudioSource _musicSource;

    [SerializeField]
    private AudioSource _effectsSource;

    [SerializeField]
    private AudioMixer _mixer;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void PlaySound(AudioClip clip)
    {
        _effectsSource.PlayOneShot(clip);
    }

    public void PlayBackgroundMusic(AudioClip clip)
    {
        _musicSource.time = 0f;
        _musicSource.loop = true;
        _musicSource.clip = clip;
        _musicSource.Play();
    }
}
