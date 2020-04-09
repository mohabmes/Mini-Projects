
import hello.CoffeeMachineInterface;
import hello.OldCoffeeMachine;

public class CoffeeTouchscreenAdapter implements CoffeeMachineInterface {
	public OldCoffeeMachine oldMachine;
	public CoffeeTouchscreenAdapter ( OldCoffeeMachine oldMachine) {
		this.oldMachine = oldMachine; }
	public void chooseFirstSelection() { oldMachine.selectA(); }
	public void chooseSecondSelection() { oldMachine.selectB(); }
}