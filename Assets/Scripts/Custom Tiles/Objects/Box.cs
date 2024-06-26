using UnityEngine;

[CreateAssetMenu(menuName = "Game Tiles/Objects/Box Tile")]
public class BoxTile : GameTile
{
    // Returns the tile type
    public override ObjectTypes GetTileType() { return ObjectTypes.Box; }
}