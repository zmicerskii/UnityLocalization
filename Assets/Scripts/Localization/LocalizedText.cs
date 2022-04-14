using UnityEngine;
using TMPro;

public class LocalizedText : MonoBehaviour
{
    [SerializeField]
    private string _key;

    private LocalizationManager _localizationManager;
    private TMP_Text _text;
    
    private void Awake()
    {
        if (_localizationManager == null)
        {
            _localizationManager = GameObject.FindGameObjectWithTag("LocalizationManager").GetComponent<LocalizationManager>();
        }
        if (_text == null)
        {
            _text = GetComponent<TMP_Text>();
        }
        _localizationManager.ChangeLanguageText += UpdateText;
    }

    private void Start()
    {
        UpdateText();
    }
    
    private void UpdateText()
    {
        if (gameObject == null) return;

        if (_localizationManager == null)
        {
            _localizationManager = GameObject.FindGameObjectWithTag("LocalizationManager").GetComponent<LocalizationManager>();
        }
        if (_text == null)
        {
            _text = GetComponent<TMP_Text>();
        }
        _text.text = _localizationManager.GetLocalizedValue(_key);
    }
    
    private void OnDestroy()
    {
        _localizationManager.ChangeLanguageText -= UpdateText;
    }
}
