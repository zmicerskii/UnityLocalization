using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LocalizationManager : MonoBehaviour
{
    public event Action ChangeLanguageText;
    
    private string _currentLanguage;
    private Dictionary<string, string> _localizedText;

    private void Awake()
    {
        if (!PlayerPrefs.HasKey("Language"))
        {
            if (Application.systemLanguage is SystemLanguage.Russian or SystemLanguage.Ukrainian or SystemLanguage.Belarusian)
            {
                PlayerPrefs.SetString("Language", "ru_RU");
            }
            else
            {
                PlayerPrefs.SetString("Language", "en_US");
            }
        }
        _currentLanguage = PlayerPrefs.GetString("Language");

        LoadLocalizedText(_currentLanguage);
    }

    public void LoadLocalizedText(string langName)
    {
        var path = Application.streamingAssetsPath + "/Languages/" + langName + ".json";

        var dataAsJson = File.ReadAllText(path);

        var loadedData = JsonUtility.FromJson<LocalizationData>(dataAsJson);

        _localizedText = new Dictionary<string, string>();
        foreach (var text in loadedData.items)
        {
            _localizedText.Add(text.key, text.value);
        }
        
        PlayerPrefs.SetString("Language", langName);
        _currentLanguage = PlayerPrefs.GetString("Language");

        ChangeLanguageText?.Invoke();
    }

    public string GetLocalizedValue(string key)
    {
        if (_localizedText.ContainsKey(key))
        {
            return _localizedText[key];
        }

        throw new Exception("Localized text with key \"" + key + "\" not found");
    }
}
