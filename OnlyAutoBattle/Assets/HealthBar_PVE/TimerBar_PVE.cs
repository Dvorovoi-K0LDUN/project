public class TimeBar : Bar
{

    private Timer _timer;

    public void Initialize(Timer timer) => _timer = timer;

    private void OnEnable()
    {
        if (_timer != null)
        _timer.HasBeenUpdated += OnValueChanged;
    }

    private void OnDisable()
    {
        if (_timer != null)
            _timer.HasBeenUpdated -= OnValueChanged;
    }
}