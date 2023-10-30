using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AutoBattle : MonoBehaviour
{
    [Header("UI Elements")]
    [SerializeField] private Slider heroHealthBar;
    [SerializeField] private Slider heroManaBar;

    [Header("Buttons")]
    [SerializeField] private Button ability1Button;
    [SerializeField] private Button ability2Button;

    [Header("Player Stats")]
    [SerializeField] private float heroMaxHealth = 100f;
    [SerializeField] private float heroMaxMana = 100f;
    [SerializeField] private float heroCurrentHealth;
    [SerializeField] private float heroCurrentMana;

    private void Start()
    {
        heroCurrentHealth = heroMaxHealth;
        heroCurrentMana = heroMaxMana;

        ability1Button.onClick.AddListener(Ability1);
        ability2Button.onClick.AddListener(Ability2);

        UpdateHeroHealthBar();
        UpdateHeroManaBar();

        StartCoroutine(ManaDecay());
        StartCoroutine(Combat());
    }

    void Ability1()
    {
        if (heroCurrentMana >= 10)
        {
            heroCurrentMana -= 10;
            heroCurrentHealth -= 20;

            UpdateHeroManaBar();
            UpdateHeroHealthBar();
        }
    }

    void Ability2()
    {
        if (heroCurrentMana >= 15)
        {
            heroCurrentMana -= 15;
            heroCurrentHealth -= 30;

            UpdateHeroManaBar();
            UpdateHeroHealthBar();
        }
    }

    IEnumerator ManaDecay()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            heroCurrentMana--;
            heroCurrentMana = Mathf.Clamp(heroCurrentMana, 0f, heroMaxMana);
            UpdateHeroManaBar();
        }
    }

    IEnumerator Combat()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            heroCurrentHealth -= 10;

            UpdateHeroHealthBar();
        }
    }

    void UpdateHeroHealthBar()
    {
        float heroHealthRatio = heroCurrentHealth / heroMaxHealth;
        heroHealthBar.value = heroHealthRatio;
    }

    void UpdateHeroManaBar()
    {
        float heroManaRatio = heroCurrentMana / heroMaxMana;
        heroManaBar.value = heroManaRatio;
    }
}
