using UnityEngine;
using UnityEngine.UI;

public class SoundSettingsManager : MonoBehaviour
{
    public SoundSettings soundSettings; // Ссылка на ScriptableObject SoundSettings
    public Slider volumeSlider; // Ссылка на Slider для громкости
    public Text uniqueIDText; // Ссылка на Text для отображения уникального ID

    void Start()
    {
        if (volumeSlider != null)
        {
            volumeSlider.value = soundSettings.volume; // Устанавливаем начальную громкость из SO
            volumeSlider.onValueChanged.AddListener(UpdateVolume); // Обновление громкости при изменении Slider
        }

        if (uniqueIDText != null)
        {
            uniqueIDText.text = soundSettings.uniqueID; // Отображаем уникальный ID
        }
    }

    // Метод для отображения списка звуков
    public void ShowList()
    {
        soundSettings.ShowList();
    }

    // Метод для отображения многострочного текста
    public void ShowTextField()
    {
        soundSettings.ShowTextField();
    }

    // Метод для скрытия всех элементов
    public void HideAll()
    {
        if (volumeSlider != null)
            volumeSlider.gameObject.SetActive(false);

        if (uniqueIDText != null)
            uniqueIDText.gameObject.SetActive(false);
    }

    // Метод для обновления громкости
    void UpdateVolume(float value)
    {
        soundSettings.volume = value; // Обновляем громкость в SO
        // Дополнительная логика для изменения громкости в игре
    }
}