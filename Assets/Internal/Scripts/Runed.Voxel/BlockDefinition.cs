﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runed.Voxel
{
    public class BlockDefinition
    {
        public virtual string Identifier { get; }
        public virtual string DisplayName { get; }
    }
}