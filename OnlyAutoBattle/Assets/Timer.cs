using System;
using System.Collections;
using UnityEngine;

public class Timer
{
    private float _time;
    private float _remainingTime;
    private IEnumerator _countdown;
    private MonoBehaviour _context;
    public event Action<float> HasBeenUpdated;
    public event Action TimeIsOver;
    private bool _isCounting = false; // ���� ��� ������������ ��������� �������

    public Timer(MonoBehaviour context) => _context = context;

    public void Set(float time)
    {
        _time = time;
        _remainingTime = _time;
    }

    public void StartCountingTime()
    {
        if (!_isCounting)
        {
            _countdown = Countdown();
            _context.StartCoroutine(_countdown);
            _isCounting = true;
        }
    }

    private IEnumerator Countdown()
    {
        while (_remainingTime > 0)
        {
            yield return new WaitForSeconds(1f); // �������� 1 �������
            _remainingTime -= 1f; // ���������� ����������� ������� �� 1 �������
            HasBeenUpdated?.Invoke(_remainingTime); // ����� ������� ���������� �������
        }

        // ����� �������
        TimeIsOver?.Invoke();
        _isCounting = false;
    }
}
