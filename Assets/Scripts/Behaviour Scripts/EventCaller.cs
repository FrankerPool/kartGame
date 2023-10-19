using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventCaller : MonoBehaviour
{
    public UnityEvent onStartEvent;
    public UnityEvent onFinishEvent;
    public float timeEvent;
    private void Start()
    {
        StartCoroutine(callEvents());
    }
    public void executeEventOnStart()
    {
        onStartEvent?.Invoke();
    }
    public void executeEventOnFinish()
    {
        onFinishEvent?.Invoke();
    }
    public IEnumerator callEvents()
    {
        executeEventOnStart();
        yield return new WaitForSeconds(timeEvent);
        executeEventOnFinish();
    }
}
