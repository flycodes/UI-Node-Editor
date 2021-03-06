﻿using NodeEditor;
using UnityEngine;

namespace UINodeEditor
{
	[Title("Builder","Matrix4x4")]
	public class MatrixBuilderNode : AbstractNode
	{
		private ValueSlot<Vector3> m_Pos;
		private ValueSlot<Quaternion> m_Rot;
		private ValueSlot<Vector3> m_Scale;

		public MatrixBuilderNode()
		{
			name = "Matrix Builder";
			CreateOutputSlot<GetterSlot<Matrix4x4>>("Out").SetGetter(() => Matrix4x4.TRS(m_Pos[this], m_Rot[this], m_Scale[this]));
			m_Pos = CreateInputSlot<ValueSlot<Vector3>>("Position").SetShowControl();
			m_Rot = CreateInputSlot<ValueSlot<Quaternion>>("Rotation").SetShowControl();
			m_Scale = CreateInputSlot<ValueSlot<Vector3>>("Scale").SetShowControl();
		}
	}
}