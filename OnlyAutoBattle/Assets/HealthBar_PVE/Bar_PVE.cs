using UnityEngine;
using UnityEngine.UI;

public abstract class Bar : MonoBehaviour
{
    [SerializeField] private Image _filler;

    protected void OnValueChanged(float valueInParts)
        => _filler.fillAmount = valueInParts;

 }