using EntityObjects.src;

namespace TestApp;
public class Goblin {

	public int MaxHealth { get; }
	private string SpriteLink;
	private string BehaviourScriptLink;

	public Goblin(UnitData unitData) {
		MaxHealth = unitData.MaxHealth;
		SpriteLink = unitData.SpriteLink;
		BehaviourScriptLink = unitData.BehaviourScriptLink;
	}
}
