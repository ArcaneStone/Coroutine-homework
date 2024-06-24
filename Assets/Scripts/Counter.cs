using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] private Text _counterText;

    private Coroutine _counterCoroutine;
    private float _counter = 0;
    private bool _isCounting = false;

    void Start()
    {
        _counterText.text = _counter.ToString();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ToggleCounter();
        }
    }

    private void ToggleCounter()
    {
        _isCounting = !_isCounting;

        if (_isCounting)
        {
            _counterCoroutine = StartCoroutine(CountUp());
        }
        else
        {
            StopCoroutine(_counterCoroutine);
        }
    }

    private IEnumerator CountUp()
    {
        bool isWork = true;
        float delayInSeconds = 0.5f;

        while (isWork)
        {
            yield return new WaitForSeconds(delayInSeconds);

            _counter += 1;
            _counterText.text = _counter.ToString();
        }
    }
}
