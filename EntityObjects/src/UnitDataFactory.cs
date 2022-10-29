using EntityObjects.interfaces;
using Newtonsoft.Json;

namespace EntityObjects.src;
public class UnitDataFactory : IUnitLoader {
	private readonly Dictionary<string, UnitData> _UnitDataList = new();
	private readonly string _FolderPath = "";

	public UnitDataFactory(string folderPath) {
		if (string.IsNullOrWhiteSpace(folderPath))
			throw new IOException("Folder not allowed to be null");

		_FolderPath = folderPath;
	}


	private void Reload() {
		_UnitDataList.Clear();

		var files = Directory.GetFiles(_FolderPath, "*.json");

		foreach (var file in files) {
			var fileContents = File.ReadAllText(file);
			var unitData = JsonConvert.DeserializeObject<UnitData>(fileContents);
			var key = Path.GetFileNameWithoutExtension(file);
			_UnitDataList.Add(key, unitData);
		}
	}

	public KeyValuePair<string, UnitData>[] GetUnitData() {
		Reload();
		return _UnitDataList.ToArray();
	}
}
