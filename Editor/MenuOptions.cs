
using UnityEditor;
using System.IO;

namespace FolderPresets
{
	public static class MenuOptions
	{
		[MenuItem( "Assets/Create/Folder Presets/Selections/Create", true, 20)]
		static bool ValidateCreateSelections()
		{
			for( Directories i0 = 0; i0 < Directories.Count; ++i0)
			{
				string key = $"{typeof( Setting)}#{i0}";
				string value = EditorUserSettings.GetConfigValue( key);
				bool setting;
				
				if( bool.TryParse( value, out setting) == false)
				{
					setting = false;
				}
				if( setting != false)
				{
					return true;
				}
			}
			return false;
		}
		[MenuItem( "Assets/Create/Folder Presets/Selections/Create", false, 20)]
		internal static void CreateSelections()
		{
			for( Directories i0 = 0; i0 < Directories.Count; ++i0)
			{
				string key = $"{typeof( Setting)}#{i0}";
				string value = EditorUserSettings.GetConfigValue( key);
				bool setting;
				
				if( bool.TryParse( value, out setting) == false)
				{
					setting = false;
				}
				if( setting != false)
				{
					CreateDirectory( i0);
				}
			}
		}
		[MenuItem( "Assets/Create/Folder Presets/Animations", true, 31)]
		static bool ValidateCreateAnimations()
		{
			return ValidateCreate( Directories.Animations);
		}
		[MenuItem( "Assets/Create/Folder Presets/Animations", false, 31)]
		static void CreateAnimations()
		{
			CreateDirectory( Directories.Animations);
		}
		[MenuItem( "Assets/Create/Folder Presets/AnimatorControllers", true, 31)]
		static bool ValidateCreateAnimatorControllers()
		{
			return ValidateCreate( Directories.AnimatorControllers);
		}
		[MenuItem( "Assets/Create/Folder Presets/AnimatorControllers", false, 31)]
		static void CreateAnimatorControllers()
		{
			CreateDirectory( Directories.AnimatorControllers);
		}
		[MenuItem( "Assets/Create/Folder Presets/AudioClips", true, 31)]
		static bool ValidateCreateAudioClips()
		{
			return ValidateCreate( Directories.AudioClips);
		}
		[MenuItem( "Assets/Create/Folder Presets/AudioClips", false, 31)]
		static void CreateAudioClips()
		{
			CreateDirectory( Directories.AudioClips);
		}
		[MenuItem( "Assets/Create/Folder Presets/Editor", true, 31)]
		static bool ValidateCreateEditor()
		{
			return ValidateCreate( Directories.Editor);
		}
		[MenuItem( "Assets/Create/Folder Presets/Editor", false, 31)]
		static void CreateEditor()
		{
			CreateDirectory( Directories.Editor);
		}
		[MenuItem( "Assets/Create/Folder Presets/Materials", true, 31)]
		static bool ValidateCreateMaterials()
		{
			return ValidateCreate( Directories.Materials);
		}
		[MenuItem( "Assets/Create/Folder Presets/Materials", false, 31)]
		static void CreateMaterials()
		{
			CreateDirectory( Directories.Materials);
		}
		[MenuItem( "Assets/Create/Folder Presets/Models", true, 31)]
		static bool ValidateCreateModels()
		{
			return ValidateCreate( Directories.Models);
		}
		[MenuItem( "Assets/Create/Folder Presets/Models", false, 31)]
		static void CreateModels()
		{
			CreateDirectory( Directories.Models);
		}
		[MenuItem( "Assets/Create/Folder Presets/Playables", true, 31)]
		static bool ValidateCreatePlayables()
		{
			return ValidateCreate( Directories.Playables);
		}
		[MenuItem( "Assets/Create/Folder Presets/Playables", false, 31)]
		static void CreatePlayables()
		{
			CreateDirectory( Directories.Playables);
		}
		[MenuItem( "Assets/Create/Folder Presets/Prefabs", true, 31)]
		static bool ValidateCreatePrefabs()
		{
			return ValidateCreate( Directories.Prefabs);
		}
		[MenuItem( "Assets/Create/Folder Presets/Prefabs", false, 31)]
		static void CreatePrefabs()
		{
			CreateDirectory( Directories.Prefabs);
		}
		[MenuItem( "Assets/Create/Folder Presets/Runtime", true, 31)]
		static bool ValidateCreateRuntime()
		{
			return ValidateCreate( Directories.Runtime);
		}
		[MenuItem( "Assets/Create/Folder Presets/Runtime", false, 31)]
		static void CreateRuntime()
		{
			CreateDirectory( Directories.Runtime);
		}
		[MenuItem( "Assets/Create/Folder Presets/Scenes", true, 31)]
		static bool ValidateCreateScenes()
		{
			return ValidateCreate( Directories.Scenes);
		}
		[MenuItem( "Assets/Create/Folder Presets/Scenes", false, 31)]
		static void CreateScenes()
		{
			CreateDirectory( Directories.Scenes);
		}
		[MenuItem( "Assets/Create/Folder Presets/Scripts", true, 31)]
		static bool ValidateCreateScripts()
		{
			return ValidateCreate( Directories.Scripts);
		}
		[MenuItem( "Assets/Create/Folder Presets/Scripts", false, 31)]
		static void CreateScripts()
		{
			CreateDirectory( Directories.Scripts);
		}
		[MenuItem( "Assets/Create/Folder Presets/Shaders", true, 31)]
		static bool ValidateCreateShaders()
		{
			return ValidateCreate( Directories.Shaders);
		}
		[MenuItem( "Assets/Create/Folder Presets/Shaders", false, 31)]
		static void CreateShaders()
		{
			CreateDirectory( Directories.Shaders);
		}
		[MenuItem( "Assets/Create/Folder Presets/Sprites", true, 31)]
		static bool ValidateCreateSprites()
		{
			return ValidateCreate( Directories.Sprites);
		}
		[MenuItem( "Assets/Create/Folder Presets/Sprites", false, 31)]
		static void CreateSprites()
		{
			CreateDirectory( Directories.Sprites);
		}
		[MenuItem( "Assets/Create/Folder Presets/Textures", true, 31)]
		static bool ValidateCreateTextures()
		{
			return ValidateCreate( Directories.Textures);
		}
		[MenuItem( "Assets/Create/Folder Presets/Textures", false, 31)]
		static void CreateTextures()
		{
			CreateDirectory( Directories.Textures);
		}
		[MenuItem( "Assets/Create/Folder Presets/Timelines", true, 31)]
		static bool ValidateCreateTimelines()
		{
			return ValidateCreate( Directories.Timelines);
		}
		[MenuItem( "Assets/Create/Folder Presets/Timelines", false, 31)]
		static void CreateTimelines()
		{
			CreateDirectory( Directories.Timelines);
		}
		static bool ValidateCreate( Directories directory)
		{
			string key = $"{typeof( Setting)}#{directory}";
			string value = EditorUserSettings.GetConfigValue( key);
			bool setting;
			
			if( bool.TryParse( value, out setting) == false)
			{
				setting = false;
			}
			Menu.SetChecked( $"Assets/Create/Folder Presets/{directory}", setting);
			return true;
		}
		static void CreateDirectory( Directories directory)
		{
			for( int i0 = 0; i0 < Selection.assetGUIDs.Length; ++i0)
			{
				string assetPath = AssetDatabase.GUIDToAssetPath( Selection.assetGUIDs[ i0]);
				
				if( string.IsNullOrEmpty( assetPath) == false)
				{
					if( AssetDatabase.IsValidFolder( assetPath) == false)
					{
						assetPath = Path.GetDirectoryName( assetPath);
					}
					if( AssetDatabase.IsValidFolder( assetPath) != false)
					{
						string path = $"{assetPath}/{directory}";
						
						if( Directory.Exists( path) == false)
						{
							Directory.CreateDirectory( path);
							AssetDatabase.ImportAsset( path);
						}
					}
				}
			}
		}
	}
}