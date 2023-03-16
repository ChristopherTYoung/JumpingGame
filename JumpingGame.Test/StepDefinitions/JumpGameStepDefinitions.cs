namespace JumpingGame.Test.StepDefinitions
{
    [Binding]
    public sealed class JumpGameStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public JumpGameStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("game has started")]
        public void GameHasStarted()
        {

            throw new PendingStepException();4 /;''
        }

        [Given("board value is true")]
        public void BoardValueIsTrue()
        {

            throw new PendingStepException();
        }

        [When("the board is generated")]
        public void TheBoardIsGenerated()
        {

            throw new PendingStepException();
        }

        [Then("console displays board")]
        public void ConsoleDisplaysBoard()
        {

            throw new PendingStepException();
        }
    }
}