using NUnit.Framework;
using RoverKataH.Commands;
using RoverKataH.Direction;
using RoverKataH.Grid;
using RoverKataH.Rover;

namespace RoverKataHTests
{
    [TestFixture]
    public class RoverTests
    {
        [SetUp]
        public void Setup()
        {
            _grid = new Grid(5);
            _commandList = new CommandList();
        }

        private IGrid _grid;
     
        private ICommandList _commandList;


        [Test]
        [TestCase("LMLMLMLMM", 1, 2, "North")]
        [TestCase("RLMMR", 0, 2, "East")]
        public void ExecuteCommands_With_Multiple_Commands(string commandString, int xCoordinateExpected,
            int yCoordinateExpected, string directionExpected)
        {
            //Arrange
            var rover = new Rover(_grid, _commandList);
            //Act
            rover.ExecuteCommands(commandString);

            //Assert
            Assert.That(rover.CoordinateX, Is.EqualTo(xCoordinateExpected));
            Assert.That(rover.CoordinateY, Is.EqualTo(yCoordinateExpected));
            Assert.That(rover.Direction.ToString(), Is.EqualTo(directionExpected));
        }


        [Test]
        public void Given_Position_With_Default_Direction_And_Forward_Command_Returns_0_1_N()
        {
            //Arrange
            var rover = new Rover(_grid, _commandList);

            //Act
            rover.ExecuteCommands("M");

            //Assert
            Assert.That(rover.CoordinateX, Is.EqualTo(0));
            Assert.That(rover.CoordinateY, Is.EqualTo(1));
            Assert.That(rover.Direction, Is.TypeOf(typeof(North)));
        }



        [Test]
        public void When_Rover_Command_Is_Forward_And_TurnRight_The_Direction_Is_East()
        {
            //Arrange
            var rover = new Rover(_grid, _commandList);

            var command = "MR";
            //Act
            rover.ExecuteCommands(command);
            //Assert
            Assert.That(rover.Direction, Is.TypeOf<East>());
            Assert.That(rover.CoordinateX, Is.EqualTo(0));
            Assert.That(rover.CoordinateY, Is.EqualTo(1));
        }


        [Test]
        public void When_Rover_Command_Is_Left_And_The_Direction_Is_West_With_Default_Coordinates()
        {
            //Arrange
            var rover = new Rover(_grid, _commandList);

            var command = "L";

            //Act
            rover.ExecuteCommands(command);
            //Assert
            Assert.That(rover.Direction, Is.TypeOf<West>());
            Assert.That(rover.CoordinateX, Is.EqualTo(0));
            Assert.That(rover.CoordinateY, Is.EqualTo(0));
        }


        [Test]
        public void When_Rover_Command_Is_Right_And_The_Direction_Is_East_With_Default_Coordinates()
        {
            //Arrange
            var rover = new Rover(_grid, _commandList);
            var command = "R";
            //Act
            rover.ExecuteCommands(command);
            //Assert
            Assert.That(rover.Direction, Is.TypeOf<East>());
            Assert.That(rover.CoordinateX, Is.EqualTo(0));
            Assert.That(rover.CoordinateY, Is.EqualTo(0));
        }

        [Test]
        public void When_Rover_Is_Created_And_Turn_Left_The_Direction_Is_West()
        {
            //Arrange
            var rover = new Rover(_grid, _commandList);
            //Act
            rover.TurnLeft();
            //Assert
            Assert.That(rover.Direction, Is.TypeOf<West>());
        }


        [Test]
        public void When_Rover_Is_Created_And_Turn_Right_The_Direction_Is_East()
        {
            //Arrange
            var rover = new Rover(_grid, _commandList);
            //Act
            rover.TurnRight();
            //Assert
            Assert.That(rover.Direction, Is.TypeOf<East>());
        }
    }
}