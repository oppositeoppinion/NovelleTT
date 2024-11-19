using Naninovel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Naninovel.Command;

[CommandAlias("loadMinigame")]
public class SwitchToMinigame : Command
{
    public override async UniTask ExecuteAsync(AsyncToken asyncToken)
    {
        Debug.Log("tryingloadscene");
        // 1. Disable Naninovel input.
        var inputManager = Engine.GetService<IInputManager>();
        inputManager.ProcessInput = false;

        // 2. Stop script player.
        var scriptPlayer = Engine.GetService<IScriptPlayer>();
        scriptPlayer.Stop();

        // 3. Reset state.
        var stateManager = Engine.GetService<IStateManager>();
        await stateManager.ResetStateAsync();

        // 4. Switch cameras.
        var naniCamera = Engine.GetService<ICameraManager>().Camera;
        naniCamera.enabled = false;

        await SceneManager.LoadSceneAsync(1);
    }
}
