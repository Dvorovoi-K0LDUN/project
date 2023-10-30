using UnityEngine;

public class Example : MonoBehaviour
{
    [SerializeField] private TimeBar _bar;

    private void Awake()
    {
        Timer timer = new Timer(this);

        _bar.Initialize(timer);

        timer.Set(5);
        timer.StartCountingTime();
    }
}