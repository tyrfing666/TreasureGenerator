using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasureGenerator
{
    /// <summary>
    /// Basic interface for a treasure
    /// </summary>
    interface ITreasure
    {
        /// <summary>
        /// The cost in GP to make the item
        /// </summary>
        int CostInGoldPieces { get; }

        /// <summary>
        /// The price in GP for the item. Usually 2x the cost.
        /// </summary>
        int PriceInGoldPieces { get; }

        /// <summary>
        /// Description of the item
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The normal caster level. Indicates difficulty in dispelling, crafting item etc.
        /// </summary>
        int NormalCasterLevel { get; }

        /// <summary>
        /// The minimum caster level. This would be the minimum level for the spells involved. Some items have a multiple, others just have an integer.
        /// </summary>
        int MinimumCasterLevel { get; }

        // should have a collection of IPrerequisite or something for the pre-requisites
        IList<string> Prerequisite { get;  }

        /// <summary>
        /// Make a treasure of the type we're looking at.
        /// </summary>
        /// <returns>The treasure</returns>
        ITreasure Create();
    }
}
