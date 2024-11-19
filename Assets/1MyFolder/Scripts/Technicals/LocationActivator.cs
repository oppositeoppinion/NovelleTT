using Naninovel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CommandAlias("deactivateSchool")]
public class SchooldDeActivator : Command
{
    public override async UniTask ExecuteAsync(AsyncToken asyncToken)
    {
        LocationsHolder.Instance.SchoolLocationButton.GetComponent<Button>().enabled = false;
    }
}
[CommandAlias("activateSchool")]
public class SchoolActivator : Command
{
    public override async UniTask ExecuteAsync(AsyncToken asyncToken)
    {
        LocationsHolder.Instance.SchoolLocationButton.GetComponent<Button>().enabled = true;
    }
}

