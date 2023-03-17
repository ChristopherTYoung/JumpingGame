using JumpingGameClassLibrary;

namespace JumpingGame.Test.StepDefinitions
{
    [Binding]
    public sealed class JumpGameStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly Board _board;

        public JumpGameStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _board = new Board();
        }

        [When("game is started")]
        public void GameStarted()
        {
            _board.RunGame();
        }
        [Then("game is running")]
        public void GameIsRunning()
        {
            _board.GameIsRunning.Should().BeTrue();
        }
        [When("board is generated")]
        public void BoardGenerated()
        {
            string boardString = _board.GenerateBoard();
            _scenarioContext.Add("board", boardString);
        }
        [Then("string representation is created")]
        public void Board()
        {
            
            string expectedString = "";
            _scenarioContext["board"].Should().Be(expectedString);
        }
    }
}