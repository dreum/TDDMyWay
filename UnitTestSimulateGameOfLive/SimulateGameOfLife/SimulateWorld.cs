using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulateGameOfLife
{
    public class SimulateWorld
    {
        public List<Cell> Simulate()
        {
            return new List<Cell>() { Cell.Dead, Cell.Alive, Cell.Dead, Cell.Alive, Cell.Dead, Cell.Alive, Cell.Dead, Cell.Alive, Cell.Dead };
        }
    }
}
