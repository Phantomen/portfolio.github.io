﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/State")]
public class State : ScriptableObject {
	public StateAction[] actions;
	public StateTransition[] transitions;
	public Color sceneGizmoColor = Color.grey;


    public void ResetAction(StateController controller)
    {
        for (int i = 0; i < actions.Length; i++)
        {
            actions[i].Reset(controller);
        }
    }


	public void UpdateState(StateController controller)
	{
		DoActions (controller);
		CheckTransitions (controller);
	}

	private void DoActions(StateController controller)
	{
		for (int i = 0; i < actions.Length; i++)
		{
			actions [i].Act (controller);
		}
	}

	private void CheckTransitions(StateController controller)
	{
		for (int i = 0; i < transitions.Length; i++)
		{
			bool decisionSucceeded = transitions [i].decision.Decide (controller);

			if (decisionSucceeded)
			{
				controller.TransitionToState (transitions [i].trueState);
                break;
			}
            else
			{
				controller.TransitionToState (transitions[i].falseState);
			}
		}
	}
}
