using UnityEngine;
using UnityEngine.UI;

public class SoundSettingsManager : MonoBehaviour
{
    public SoundSettings soundSettings;     // Ссылка на ScriptableObject SoundSettings
    public Slider volumeSlider;             // Ссылка на Slider для громкости
    public Text uniqueIDText;               // Ссылка на Text для отображения уникального ID

    private void Start()
    {
        if (volumeSlider != null)
        {
            volumeSlider.value = soundSettings.volume;
            volumeSlider.onValueChanged.AddListener(UpdateVolume);
        }

        if (uniqueIDText != null)
        {
            uniqueIDText.text = soundSettings.uniqueID;
        }
    }
    
    public void ShowList()
    {
        soundSettings.ShowList();
    }
    
    public void ShowTextField()
    {
        soundSettings.ShowTextField();
    }
    
    public void HideAll()
    {
        if (volumeSlider != null)
            volumeSlider.gameObject.SetActive(false);

        if (uniqueIDText != null)
            uniqueIDText.gameObject.SetActive(false);
    }
    
    void UpdateVolume(float value)
    {
        soundSettings.volume = value; // Обновляем громкость в SO
    }
}