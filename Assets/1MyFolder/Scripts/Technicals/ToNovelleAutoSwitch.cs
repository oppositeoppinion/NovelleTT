using DTT.MinigameMemory;
using Naninovel;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToNovelleAutoSwitch : MonoBehaviour
{
    [SerializeField] private MemoryGameManager _manager;
    [SerializeField] private MemoryGameSettings _settings;

    private void Start()
    {
        _manager.Finish += ToNovelle;
    }


    [ContextMenu("to novelle")]
    public void ToNovelle(MemoryGameResults obj)
    {
        StartCoroutine(ToNovelle());

    }

    private IEnumerator ToNovelle()
    {
        yield return new WaitForSeconds(1f);
        // _manager.StopAllCoroutines();
        //_manager.Pause();
        Debug.Log("MemoryGame Finished");
        var switchToNovelle = new SwitchToNovelle { };
        AsyncToken asyncToken = new AsyncToken();
        switchToNovelle.ExecuteAsync(asyncToken).Forget();
    }

    private void OnDestroy()
    {
        _manager.Finish -= ToNovelle;
    }
}
