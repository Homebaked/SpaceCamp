using System;
using Nez;
using Nez.UI;
using SpaceCamp.Scenes;

namespace SpaceCamp.UI
{
    public class GridInterface : UICanvas
    {
        private Grid grid;

        public GridInterface(Grid grid)
        {
            this.grid = grid;

            Label nameLabel = new Label("Name: ");

            Table table = stage.addElement(new Table());
            table.add(nameLabel);
            table.add(grid.selectedEntity.name);
        }
    }
}
