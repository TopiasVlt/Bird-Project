using UnityEngine;
using UnityEngine.UI;
public class UIController : MonoBehaviour
{
    public Slider _musicSlider, _sfxSlider;


   public void MusicVolume()
    {
        AudioManager.Instance.MusicVolume(_musicSlider.value);
    }
    
    public void SFXVolume()
    {
        AudioManager.Instance.SFXVolume(_sfxSlider.value);
    }
}