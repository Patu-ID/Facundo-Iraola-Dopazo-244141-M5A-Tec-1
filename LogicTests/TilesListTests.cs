using Logic;

namespace TileListTests;

public class TilesListTests
{
    public void CreateTileWithValidDataShouldReturnValidCost()
    {
        // Arrange
        Material material =  new Material("Steel", 10);
        int[] dimensions = new int[1];
        dimensions[0] = 8;
        Shape shape = new Shape("Square", dimensions);

        Tile tile = new Tile(material, shape);
        
        int numberOfTiles = 10; 

        List<Tile> tiles = new List<Tile>();

        for (int i = 0; i < numberOfTiles; i++)
        {
        tiles.Add(tile);
        }

        
        TileList tileList = new TileList(tiles);
        
        // Assert
        Assert.AreEqual(tileList.TotalCost, 6400);
    }
    public void CreateTileWithValidDataShouldReturnValidArea()
    {
        // Arrange
        Material material =  new Material("Steel", 10);
        int[] dimensions = new int[1];
        dimensions[0] = 8;
        Shape shape = new Shape("Square", dimensions);

        Tile tile = new Tile(material, shape);
        
        int numberOfTiles = 10; 

        List<Tile> tiles = new List<Tile>();

        for (int i = 0; i < numberOfTiles; i++)
        {
            tiles.Add(tile);
        }

        
        TileList tileList = new TileList(tiles);
        
        // Assert
        Assert.AreEqual(tileList.TotalArea, 6400);
    }

}