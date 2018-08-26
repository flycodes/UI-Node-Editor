﻿using System;
using NodeEditor;

namespace UINodeEditor
{
	[Title("Execution Node")]
	public class ExecutionNode : AbstractNode
	{
		private ValueSlot<Action> Input;

		public ExecutionNode()
		{
			Input = CreateInputSlot<ValueSlot<Action>>("Input");
		}

		public void Execute()
		{
			var action = Input[this];
			if(action != null) action.Invoke();
		}
	}
}