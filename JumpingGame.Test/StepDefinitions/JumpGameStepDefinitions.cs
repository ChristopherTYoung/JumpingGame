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
        [When("the player loses")]
        public void ThePlayerLoses()
        {
            _board.EndGame();
        }
        [Then("board array is created")]
        public void BoardArrayIsCreated()
        {
            _scenarioContext["board"].Should().BeOfType<int[][]>();
        }
        [Then("string representation is created")]
        public void Board()
        {
            // Height of 8, 20 by 8
            string expectedString = "                                                                                                    \n                                                                                                    \n                                                                                                    \n                                                                                                    \n                                                                                                    \n                                                                                                    \n                                                                                                    \nTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT";

            _scenarioContext["boardString"].Should().Be(expectedString);
        }
        [Then("the game ends")]
        public void GameEnds()
        {
            _board.GameIsRunning.Should().BeFalse();
        }
        [Given("game is started")]
        public void GameIsStarted()
        {
            _board.RunGame();
        }
        [Then("player is generated on board")]
        public void PlayerIsGeneratedOnBoard()
        {
            throw new NotImplementedException();
        }
        [Given("player is generated on board")]
        public void PlayerGenerated()
        {
            throw new NotImplementedException();
        }
        [When("player hits jump")]
        public void PlayerHitJump()
        {
            throw new NotImplementedException();
        }
        [Given("advance clock")]
        public void AdvanceingTime()
        {
            throw new NotImplementedException();
        }
        [Then("player feet are at position (.*)")]
        public void PlayerIsJumping(int position)
        {
            throw new NotImplementedException();
        }
    }
}