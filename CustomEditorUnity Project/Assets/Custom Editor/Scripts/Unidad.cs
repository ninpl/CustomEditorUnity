//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Unidad.cs (24/01/2019)														\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:		Clase que contiene la informacion de una unidad.			\\
// Fecha Mod:		24/01/2019													\\
// Ultima Mod:		Version Inicial.											\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
#endregion

namespace MoonAntonio
{
	/// <summary>
	/// <para>Clase que contiene la informacion de una unidad.</para>
	/// </summary>
	[HelpURL("https://moonantonio.github.io/"), AddComponentMenu("MoonAntonio/Unidad"), System.Serializable]
	public class Unidad : MonoBehaviour 
	{
		#region Variables Publicas
		public Data data;
		#endregion

		#region Dev
		[ContextMenu("Dev")]
	    protected void DevScript()
	    {
	        Debug.Log("<color=green>Unidad :: DevScript()</color> >> Inicializado.");
	    }
	    #endregion
	}

	[System.Serializable]
	public class Data
	{
		#region Variables Publicas
		public float vida = 0.0f;
		public float mana = 0.0f;
		public bool isVivo = false;
		#endregion
	}
}