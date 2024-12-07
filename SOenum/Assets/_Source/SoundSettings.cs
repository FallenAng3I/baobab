using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSoundSettings", menuName = "Настройки Звука", order = 1)]
public class SoundSettings : ScriptableObject
{
    public AudioClip audioClip;                     // Аудиофайл для звука
    public float volume;                            // Уровень громкости
    public List<SoundSetting> dangerousSounds;      // Список опасных звуков
    public List<SoundSetting> friendlySounds;       // Список дружелюбных звуков
    public List<SoundSetting> neutralSounds;        // Список нейтральных звуков
    public string uniqueID;                         // Уникальный ID для SO
    public string multiLineText;                    // Многострочное поле для любого текстового панеля
    public AudioContentType audioContentType;       // Тип аудиоконтента (опасный, дружелюбный, нейтральный)
    
    public void ShowList()
    {
        switch(audioContentType)
        {
            case AudioContentType.Dangerous:
                break;
            case AudioContentType.Friendly:
                break;
            case AudioContentType.Neutral:
                break;
        }
    }
    
    public void ShowTextField()
    {
        // Код для отображения многострочного текстового поля
    }
    
    public void HideAll()
    {
        // Код для скрытия всех отображаемых элементов
    }
}

public enum AudioContentType
{
    Dangerous,
    Friendly,
    Neutral
}