using Naninovel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CommandAlias("loadNovelle")]
public class SwitchToNovelle : Command
{
    public override async UniTask ExecuteAsync(AsyncToken asyncToken)
    {
        Debug.Log("switchingToNovelle");

        // 1. Disable Naninovel input.
        var inputManager = Engine.GetService<IInputManager>();
        inputManager.ProcessInput = true;

        // 2. Stop script player.
        //var scriptPlayer = Engine.GetService<IScriptPlayer>();
        //scriptPlayer.Play();

        // 3. Reset state.
        var stateManager = Engine.GetService<IStateManager>();
        await stateManager.ResetStateAsync();

        // 4. Switch cameras.
        var naniCamera = Engine.GetService<ICameraManager>().Camera;
        naniCamera.enabled = true;

        await SceneManager.LoadSceneAsync(2);

        var scriptPlayer = Engine.GetService<IScriptPlayer>();
        await scriptPlayer.PreloadAndPlayAsync(scriptName:"SchoolLocation1", label:"Exam1");//"SchoolLocation1"

    }
}