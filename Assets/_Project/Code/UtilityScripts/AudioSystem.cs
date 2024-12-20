using UnityEngine;

/// <summary>
/// Insanely basic audio system which supports 3D sound.
/// Ensure you change the 'Sounds' audio source to use 3D spatial blend if you intend to use 3D sounds.
/// </summary>
public class AudioSystem : StaticInstance<AudioSystem> {
    [SerializeField] private AudioSource _musicSource;

    [SerializeField] private AudioSource _ambientSource;
    [SerializeField] private AudioSource _soundsSource;

    public void PlayMusic(AudioClip clip, float volume) {
        _musicSource.clip = clip;
        _musicSource.volume = volume;
        _musicSource.Play();
    }

    public void StopMusic() {
        _musicSource.Stop();
    }
    public void PlayAmbient(AudioClip clip, float volume) {
        _ambientSource.clip = clip;
        _ambientSource.volume = volume;
        _ambientSource.Play();
    }

    public void StopAmbient() {
        _ambientSource.Stop();
    }

    public void PlaySound(AudioClip clip, Vector3 pos, float vol = 1) {
        _soundsSource.transform.position = pos;
        PlaySound(clip, vol);
    }

    public void PlaySound(AudioClip clip, float vol = 1) {
        _soundsSource.PlayOneShot(clip, vol);
    }
}