
using UnityEngine;
using UnityEditor;
using System.IO;

namespace FolderPresets
{
	public sealed class Setting : EditorWindow
	{
		[MenuItem( "Assets/Create/Folder Presets/Selections/Setting", false, 9)]
		static void ShowWindow()
		{
			var window = GetWindow<Setting>();
			window.titleContent = new GUIContent( "Folder Preset Setting");
			window.ShowModalUtility();
		}
		void OnEnable()
		{
			minSize = windowSize;
			maxSize = windowSize;
			Undo.undoRedoPerformed += Repaint;
		}
		void OnDisable()
		{
			Undo.undoRedoPerformed -= Repaint;
		}
		void OnGUI()
		{
			for( Directories i0 = 0; i0 < Directories.Count; ++i0)
			{
				string key = $"{GetType()}#{i0}";
				string value = EditorUserSettings.GetConfigValue( key);
				bool setting;
				
				if( bool.TryParse( value, out setting) == false)
				{
					setting = false;
				}
				bool enabled = EditorGUILayout.ToggleLeft( i0.ToString(), setting);
				if( setting != enabled)
				{
					EditorUserSettings.SetConfigValue( key, enabled.ToString());
				}
			}
		}
		Vector2 windowSize
		{
			get{ return new Vector2( 200, (EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing) * (int)Directories.Count); }
		}
	}
}