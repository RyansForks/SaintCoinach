﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintCoinach.Graphics {
    public interface IUpdateable : IComponent {
        void Update(EngineTime time);
    }
}
