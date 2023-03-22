using JumpingGameClassLibrary;

namespace JumpingGame.Test.StepDefinitions
{
    [Binding]
    public sealed class JumpGameStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly Board _board;
        private readonly Player _player;

        public JumpGameStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _board = new Board();
            _player = new Player();
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
            var player = _player.Generate();
            var board = _board.GenerateBoard(player);
            
            var boardString = _board.GetBoardAsString(board, player);
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
            string expectedString = "                                                                                                    \n                                                                                                    \n                                                                                                    \n                                                                                                    \n   O                                                                                                \n   Y                                                                                                \n   L                                                                                                \nTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT";

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
            string expectedString = "                                                                                                    \n                                                                                                    \n                                                                                                    \n                                                                                                    \n   O                                                                                                \n   Y                                                                                                \n   L                                                                                                \nTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT";

            _scenarioContext["boardString"].Should().Be(expectedString);
        }
        [Given("player is generated on board")]
        public void PlayerGenerated()
        {
            string expectedString = "                                                                                                    \n                                                                                                    \n                                                                                                    \n                                                                                                    \n   O                                                                                                \n   Y                                                                                                \n   L                                                                                                \nTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT";

            _scenarioContext["boardString"].Should().Be(expectedString);
        } 
        [When("player hits jump")]
        public void PlayerHitJump()
        {
            _player.Jump();
        }
        [Given("advance clock")]
        public void AdvanceingTime()
        {
            throw new NotImplementedException();
        }
        [Then("players head is at position (.*)")]
        public void PlayerIsJumping(int position)
        {
            throw new NotImplementedException();
        }
    }
}