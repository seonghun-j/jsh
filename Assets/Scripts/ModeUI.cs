using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MOdeUI : MonoBehaviour

{
    [SerializeField]
    Button _timeAttackButton;

    [SerializeField]
    Button _stageModeButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    public void AddTimeClickEvent(UnityAction clickCallback)
    {
        _timeAttackButton.onClick.AddListener(clickCallback);
    }
    public void AddStageClickEvent(UnityAction clickCallback)
    {
        _stageModeButton.onClick.AddListener(clickCallback);
    }


}
