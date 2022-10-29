using EntityObjects.src;

namespace TestApp;
public class Player {

	public int MaxHealth { get; }
	private string SpriteLink;
	private string BehaviourScriptLink;

	public Player(UnitData unitData) {
		MaxHealth = unitData.MaxHealth;
		SpriteLink = unitData.SpriteLink;
		BehaviourScriptLink = unitData.BehaviourScriptLink;
	}
}
