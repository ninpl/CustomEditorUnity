//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// UnidadInspector.cs (24/01/2019)												\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:		Inspector de la clase Unidad.								\\
// Fecha Mod:		24/01/2019													\\
// Ultima Mod:		Version Inicial.											\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using UnityEditor;
#endregion

namespace MoonAntonio
{
	/// <summary>
	/// <para>Inspector de la clase <see cref="Unidad"/>.</para>
	/// </summary>
	[HelpURL("https://moonantonio.github.io/"), AddComponentMenu("MoonAntonio/UnidadInspector"), CustomEditor(typeof(Unidad))]
	public class UnidadInspector : Editor 
	{
		public override void OnInspectorGUI()
		{
			serializedObject.Update();

			EditorGUILayout.LabelField("Datos Unidad");
			SerializedProperty dataProperty = serializedObject.FindProperty("data");
			SerializedProperty vidaProperty = dataProperty.FindPropertyRelative("vida");
			SerializedProperty manaProperty = dataProperty.FindPropertyRelative("mana");
			SerializedProperty isVivoProperty = dataProperty.FindPropertyRelative("isVivo");

			EditorGUILayout.BeginHorizontal("box");
			vidaProperty.floatValue = EditorGUILayout.FloatField("HP", vidaProperty.floatValue);
			manaProperty.floatValue = EditorGUILayout.FloatField("MP" ,manaProperty.floatValue);
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal("box");
			isVivoProperty.boolValue = EditorGUILayout.Toggle("Alive", isVivoProperty.boolValue);
			EditorGUILayout.EndHorizontal();

			serializedObject.ApplyModifiedProperties();
		}

		#region Dev
		[ContextMenu("Dev")]
	    protected void DevScript()
	    {
	        Debug.Log("<color=green>UnidadInspector :: DevScript()</color> >> Inicializado.");
	    }
	    #endregion
	}
}