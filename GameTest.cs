using System;

public class GameTest
{
	[Setup]
	public void Game()
	{
		Player = new Player(new Position(1, 2, 0));
		RevealHiddenItem = new RevealHiddenItem(new Position(1, 24, 0));
		Gold = new Gold(Stadndard);
		Hidden = new Gold(Hidden);

		}

	#region F1 
	[Test]
	public  InitolizePlayer_IntheSpace()
	{ 
		// Arrange
        Player player = new Player(new Position(1, 2, 0));
        Position expectedPosition = new Position(1, 2, 0);

        //Act
        Position actualPosition = player.Position;

        //Assert
        Assert.AreEqual(expectedPosition, actualPosition);
		return PostionOutsideOfMapExeption;
    }
}
#endregion
#region F2
[Test]
public void MovePlayer_move()
{
	//Arrange
	Player player = new Player(new Position(1, 2, 0));
	Position expectedPosition = new Position(2, 2, 0);
	//Act
	Position actualPosition = player.MoveUp(expectedPosition);
	//Assert
	Assert.AreEqual(expectedPosition, actualPosition);
}
}
#endregion