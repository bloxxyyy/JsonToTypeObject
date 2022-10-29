using EntityObjects.interfaces;

namespace EntityObjects.src;
public class ObjectManager {
	private IUnitLoader _UnitLoader;
	public ObjectManager(IUnitLoader unitLoader) => _UnitLoader = unitLoader;

	public object? GetObject(Type type) {
		var unitDataKeyValuePairs = _UnitLoader.GetUnitData();

		foreach (var keyValuePair in unitDataKeyValuePairs) {
			if (keyValuePair.Key != type.Name)
				continue;

			return Activator.CreateInstance(type, keyValuePair.Value);
		}

		return null;
	}
}
