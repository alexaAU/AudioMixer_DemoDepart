using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GestionnaireAudio : MonoBehaviour
{

    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider sliderVolume;
    [SerializeField] private Slider sliderVolumeFX;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        // audioMixer.GetFloat("MusiqueVolume");
        // audioMixer.SetFloat("VolumeMusique", -20f);
    }

  public void AjusteVolumeMusique(float volume){
    audioMixer.SetFloat("MusiqueVolume", ConvertToLogarithmique(volume));

  }
  public void AjusteVolumeFx(float volume){
    audioMixer.SetFloat("FXVolume", ConvertToLogarithmique(volume));
    audioSource.Play();

  }
  
  private float ConvertToLogarithmique(float volume)
  {
    return Mathf.Log10(volume) * 20;
  }
}
