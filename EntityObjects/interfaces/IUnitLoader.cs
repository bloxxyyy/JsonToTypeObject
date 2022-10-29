using EntityObjects.src;

namespace EntityObjects.interfaces;

public interface IUnitLoader {
	public KeyValuePair<string, UnitData>[] GetUnitData();
}
