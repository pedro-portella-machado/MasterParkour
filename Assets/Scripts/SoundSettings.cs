using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class SoundSettings : MonoBehaviour
{
    [SerializeField] Slider soundSlider;
    [SerializeField] AudioMixer masterMixer;

    private void Start()
    {
        SetVolume(PlayerPrefs.GetFloat("Saved MasterVolume", 100));
    }

    public void SetVolume(float _Value)
    {
        if (_Value < 1)
        {
            _Value = .001f;
        }

        RefreshSlider(_Value);
        PlayerPrefs.SetFloat("SaveMasterVolume", _Value);
        masterMixer.SetFloat("MasterVolume", Mathf.Log10(_Value / 100) * 20f);
    }

    public void SetVolumeFomSlider()
    {
        SetVolume(soundSlider.value);
    }

    public void RefreshSlider(float _Value)
    {
        soundSlider.value = _Value;
    }
}