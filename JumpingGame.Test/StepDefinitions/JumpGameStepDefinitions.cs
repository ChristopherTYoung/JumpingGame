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
            var board = _board.GenerateBoard();
            var boardString = _board.GetBoardAsString(board);
            _scenarioContext.Add("board", board);
            _scenarioContext.Add("boardString", boardString);
        }
        [Then("board array is created")]
        public void BoardArrayIsCreated()
        {
            throw new PendingStepException();
        }
        [Then("string representation is created")]
        public void Board()
        {
            // Height of 8, 20 by 8
            string expectedString = @"                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT";
            _scenarioContext["boardString"].Should().Be(expectedString);
        }
    }
}