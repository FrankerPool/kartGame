using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventCaller : MonoBehaviour
{
    //this script is used for show and hide canvas
    public UnityEvent onStartEvent;
    public UnityEvent onFinishEvent;
    public float timeEvent;
    //event execute on start
    private void Start()
    {
        StartCoroutine(callEvents());
    }
    //event execute on start run time
    public void executeEventOnStart()
    {
        onStartEvent?.Invoke();
    }
    //event execute on finish the time
    public void executeEventOnFinish()
    {
        onFinishEvent?.Invoke();
    }
    //init coruotine on start execute first start event and after time execute the finish event
    public IEnumerator callEvents()
    {
        executeEventOnStart();
        yield return new WaitForSeconds(timeEvent);
        executeEventOnFinish();
    }
}
