﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Decision/MinionsGoneAndTimePassedDecisoin")]
public class MinionsGoneAndTimePassedAfterDecision : StateDecision {

    public int minionsLeft = 0;
    public float timePassedAfter = 10;
    private Timer timePassed = new Timer(-1, -1);

    public override bool Decide(StateController controller)
    {
        return DecisionMinions(controller);
    }

    private bool DecisionMinions(StateController controller)
    {
        if (timePassed.Duration == -1
            && timePassed.Time == -1)
        {
            timePassed = new Timer(timePassedAfter, 0);
        }

        if (minionsLeft < 0)
        {
            minionsLeft = 0;
        }

        if (controller.minionList.Count <= minionsLeft)
        {
            timePassed.Time += Time.deltaTime;
            return (timePassed.Expired);
        }

        else
        {
            return false;
        }
    }
}
